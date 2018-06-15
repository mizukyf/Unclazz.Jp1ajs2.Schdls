namespace Unclazz.Jp1ajs2.Schdls.Model
{
    public abstract partial class SdParamData
    {
        public abstract class YearMonthSdParamData : SdParamData
        {
            internal YearMonthSdParamData(string value, int year, int month) : base(value)
            {
                Year = year;
                Month = month;
            }

            public int Year { get; }
            public int Month { get; }
        }
    }
}
