using System;
namespace Unclazz.Jp1ajs2.Schdls.Model
{
    public class EdParamData
    {
        public static EdParamData Create(string value)
        {
            return new EdParamData(value ?? throw new ArgumentNullException(nameof(value)));
        }

        EdParamData(string value)
        {
            var values = value.Split('/');
            Year = int.Parse(values[0]);
            Month = int.Parse(values[1]);
            Day = int.Parse(values[2]);
        }

        public int Year { get; }
        public int Month { get; }
        public int Day { get; }

        public override string ToString()
        {
            return $"{Year}年{Month}月{Day}日";
        }
    }
}
