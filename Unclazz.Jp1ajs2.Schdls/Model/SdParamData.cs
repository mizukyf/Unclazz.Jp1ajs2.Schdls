using System;
using System.Text.RegularExpressions;

namespace Unclazz.Jp1ajs2.Schdls.Model
{
    public abstract partial class SdParamData : ParamDataBase
    {
        static readonly EntrySdParamData _en = new EntrySdParamData();
        static readonly UndefinedSdParamData _ud = new UndefinedSdParamData();

        static readonly Regex _re0 = new Regex(@"^([+*@])?(\d+)$");
        static readonly Regex _re1 = new Regex(@"^([+*@])?b(-\d+)?$");
        static readonly Regex _re2 = new Regex(@"^(\+)?(su|mo|tu|we|th|fr|sa)(:([nb]))?$");

        public static SdParamData Create(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            if (value == "en") return _en;
            if (value == "ud") return _ud;

            var values = value.Split('/');
            var valueYyyy = values.Length == 3 ? int.Parse(values[0]) : 0;
            var valueMm = values.Length > 1 ? int.Parse(values[values.Length - 2]) : 0;
            var valueRest = values[values.Length - 1];

            var m0 = _re0.Match(valueRest);
            if (m0.Success)
            {
                return new DaySdParamData(value, valueYyyy, valueMm, 
                       int.Parse(m0.Groups[2].Value), m0.Groups[1].Value);
            }

            var m1 = _re1.Match(valueRest);
            if (m1.Success)
            {
                var valueDd = m0.Groups[2].Value;
                var day = valueDd == string.Empty ? 0 : int.Parse(valueDd);
                return new InverseDaySdParamData(value, valueYyyy, valueMm, day, m0.Groups[1].Value);
            }

            var m2 = _re2.Match(valueRest);
            if (m2.Success)
            {
                var rel = m2.Groups[1].Value == "+";
                var valueN = m2.Groups[4].Value;
                var num = valueN == string.Empty ? 0 : (valueN == "b" ? -1 : int.Parse(valueN));
                return new DayOfWeekSdParamData(value, valueYyyy, valueMm, m2.Groups[2].Value, num, rel);
            }

            throw new ArgumentException($"unknown value '{value}'.");
        }

        public static SdParamData Default { get; } = _en;

        internal SdParamData(string value): base(value) { }
    }
}
