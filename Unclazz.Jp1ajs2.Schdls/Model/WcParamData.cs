using System;

namespace Unclazz.Jp1ajs2.Schdls.Model
{
    public class WcParamData : ParamDataBase
    {
        public static WcParamData Create(string value)
        {
            return new WcParamData(value ?? throw new ArgumentNullException(nameof(value)));
        }
        public static WcParamData Default { get; } = new WcParamData("no");

        WcParamData(string value) : base(value)
        {
            NoWait = value == "no";
            Unlimited = value == "un";
            if (NoWait || Unlimited) return;

            Count = int.Parse(value);
        }
        public bool NoWait { get; set; }
        public bool Unlimited { get; set; }
        public int Count { get; set; }

        public override string ToString()
        {
            if (NoWait)
            {
                return "起動条件なし";
            }
            if (Unlimited)
            {
                return "無制限";
            }
            return $"{Count}回まで";
        }
    }
}
