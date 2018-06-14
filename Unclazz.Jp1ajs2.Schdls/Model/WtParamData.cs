using System;

namespace Unclazz.Jp1ajs2.Schdls.Model
{
    public class WtParamData
    {
        public static WtParamData Create(string value)
        {
            return new WtParamData(value ?? throw new ArgumentNullException(nameof(value)));
        }
        public static WtParamData Default { get; } = new WtParamData("no");

        WtParamData(string value)
        {
            NoWait = value == "no";
            Unlimited = value == "un";
            if (NoWait || Unlimited) return;
            if (value.IndexOf(':') != -1)
            {
                var hhmm = value.Split(':');
                Hour = int.Parse(hhmm[0]);
                Minute = int.Parse(hhmm[1]);
            }
            else
            {
                var min = int.Parse(value);
                Hour = min / 60;
                Minute = min % 60;
            }
        }

        public bool NoWait { get; set; }
        public bool Unlimited { get; set; }
        public bool Relative { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }

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
            return Relative ? $"相対時刻{Hour}時{Minute}分まで" : $"絶対時刻{Hour}時{Minute}分まで";
        }
    }
}
