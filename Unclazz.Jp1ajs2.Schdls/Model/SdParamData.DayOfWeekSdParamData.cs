using System;
using System.Text;

namespace Unclazz.Jp1ajs2.Schdls.Model
{
    public abstract partial class SdParamData
    {
        public class DayOfWeekSdParamData : YearMonthSdParamData
        {
            internal DayOfWeekSdParamData(string value, int year, int month,
            string dayOfWeek, int num, bool relative) : base(value, year, month)
            {
                switch (dayOfWeek)
                {
                    case "su": DayOfWeek = System.DayOfWeek.Sunday; break;
                    case "mo": DayOfWeek = System.DayOfWeek.Monday; break;
                    case "tu": DayOfWeek = System.DayOfWeek.Tuesday; break;
                    case "we": DayOfWeek = System.DayOfWeek.Wednesday; break;
                    case "th": DayOfWeek = System.DayOfWeek.Thursday; break;
                    case "fr": DayOfWeek = System.DayOfWeek.Friday; break;
                    case "sa": DayOfWeek = System.DayOfWeek.Saturday; break;
                    default: throw new ArgumentException($"unknown day of week code '{dayOfWeek}'.");
                }

                Number = num;
                Relative = relative;
            }

            public DayOfWeek DayOfWeek { get; }
            public int Number { get; }
            public bool Relative { get; }

            public override string ToString()
            {
                var buff = new StringBuilder();

                if (Year > 0) buff.Append(Year).Append("年");
                if (Month > 0) buff.Append(Month).Append("月");


                if (Number == -1) buff.Append("最終の");
                if (Number == 0)
                {
                    buff.Append(Month > 0 ? "第1" : "実行登録日直近の");
                }
                else
                {
                    buff.Append("第").Append(Number);
                }

                switch (DayOfWeek)
                {
                    case System.DayOfWeek.Sunday: buff.Append("日曜日"); break;
                    case System.DayOfWeek.Monday: buff.Append("月曜日"); break;
                    case System.DayOfWeek.Tuesday: buff.Append("火曜日"); break;
                    case System.DayOfWeek.Wednesday: buff.Append("水曜日"); break;
                    case System.DayOfWeek.Thursday: buff.Append("木曜日"); break;
                    case System.DayOfWeek.Friday: buff.Append("金曜日"); break;
                    case System.DayOfWeek.Saturday: buff.Append("土曜日"); break;
                }

                return buff.ToString();
            }
        }
    }
}
