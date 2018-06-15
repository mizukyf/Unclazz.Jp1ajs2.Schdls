using System;

namespace Unclazz.Jp1ajs2.Schdls.Model
{
    public class StParamData : ParamDataBase
    {
        public static StParamData Create(string value)
        {
            return new StParamData(value ?? throw new ArgumentNullException(nameof(value)));
        }

        public static StParamData Default { get; } = new StParamData("+00:00");

        StParamData(string value) : base(value)
        {
            Relative = value.StartsWith("+");
            var hhmm = (Relative ? value.Substring(1) : value).Split(':');
            Hour = int.Parse(hhmm[0]);
            Minute = int.Parse(hhmm[1]);
        }

        public int Hour { get; set; }
        public int Minute { get; set; }
        public bool Relative { get; set; }

        public override string ToString()
        {
            return Relative ? $"相対時刻{Hour}時{Minute}分" : $"絶対時刻{Hour}時{Minute}分";
        }
    }
}
