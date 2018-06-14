using System;
using System.Linq;
using Unclazz.Jp1ajs2.Unitdef;

namespace Unclazz.Jp1ajs2.Schdls
{
    public static class SdRelParamsExtensions
    {
        public static T ParameterNvl<T>(this IUnit self, string paramName,
               int number, Func<IParameterValue, T> transform, T alternative)
        {
            var param = self.Parameters
                            .Where(x => x.Name == paramName)
                            .FirstOrDefault(x => GetRuleNumber(x) == number);
            if (param == null) return alternative;
            return transform(param.Values.Last());
        }

        static int GetRuleNumber(IParameter param)
        {
            return param.Values.Count == 1 ? 1 : int.Parse(param.Values[0].StringValue);
        }
    }
}
