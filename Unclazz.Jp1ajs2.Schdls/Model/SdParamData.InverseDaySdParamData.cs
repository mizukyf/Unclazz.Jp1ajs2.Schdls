using System.Text;

namespace Unclazz.Jp1ajs2.Schdls.Model
{
    public abstract partial class SdParamData
    {
        public class InverseDaySdParamData : DaySdParamData
        {
            internal InverseDaySdParamData(string value, int year, int month, int day, string unit)
                : base(value, year, month, day, unit)
            {
            }

            public override string ToString()
            {
                var buff = new StringBuilder();

                if (Year > 0) buff.Append(Year).Append("年");
                if (Month > 0) buff.Append(Month).Append("月");

                switch (Unit)
                {
                    case DayUnits.Absolute: buff.Append("末"); break;
                    case DayUnits.Relative: buff.Append("の相対日末日"); break;
                    case DayUnits.BusinessDay: buff.Append("の運用日末日"); break;
                    case DayUnits.NonBusinessDay: buff.Append("の休業日末日"); break;
                }

                if (Day < 0) buff.Append("の").Append(Day).Append("日前");

                return buff.ToString();
            }
        }
    }
}
