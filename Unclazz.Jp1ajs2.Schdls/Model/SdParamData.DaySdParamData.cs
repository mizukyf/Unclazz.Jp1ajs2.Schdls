using System;
using System.Text;

namespace Unclazz.Jp1ajs2.Schdls.Model
{
    public abstract partial class SdParamData
    {
        public class DaySdParamData : YearMonthSdParamData
        {
            internal DaySdParamData(string value, int year, int month, int day, string unit) : base(value, year, month)
            {
                Day = day;
                switch (unit)
                {
                    case "": Unit = DayUnits.Absolute; return;
                    case "+": Unit = DayUnits.Relative; return;
                    case "*": Unit = DayUnits.BusinessDay; return;
                    case "@": Unit = DayUnits.NonBusinessDay; return;
                    default: throw new ArgumentException($"unknown unit code '{unit}'.");
                }
            }

            public int Day { get; }
            public DayUnits Unit { get; }

            public override string ToString()
            {
                var buff = new StringBuilder();

                if (Year > 0) buff.Append(Year).Append("年");
                if (Month > 0) buff.Append(Month).Append("月");

                switch (Unit)
                {
                    case DayUnits.Absolute: break;
                    case DayUnits.Relative: buff.Append("の相対日で"); break;
                    case DayUnits.BusinessDay: buff.Append("の運用日で"); break;
                    case DayUnits.NonBusinessDay: buff.Append("の休業日で"); break;
                }

                if (Unit == DayUnits.Absolute) buff.Append(Day).Append("日");
                else buff.Append(Day).Append("日目");

                return buff.ToString();
            }

            public enum DayUnits { Absolute, Relative, BusinessDay, NonBusinessDay }
        }
    }
}
