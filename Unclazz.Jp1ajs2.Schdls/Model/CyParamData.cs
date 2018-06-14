using System;
using System.Text;
using Unclazz.Jp1ajs2.Unitdef;

namespace Unclazz.Jp1ajs2.Schdls.Model
{
    public class CyParamData
    {
        public static CyParamData Create(ITuple value)
        {
            return new CyParamData(value ?? throw new ArgumentNullException(nameof(value)));
        }
        
        CyParamData(ITuple value)
        {
            Interval = int.Parse(value[0]);
            switch (value[1])
            {
                case "y": Unit = CyUnits.Year; break;
                case "m": Unit = CyUnits.Month; break;
                case "w": Unit = CyUnits.Week; break;
                case "d": Unit = CyUnits.Day; break;
                default: throw new ArgumentException($"unknown unit code '{value[1]}'.");
            }
        }

        public int Interval { get; set; }
        public CyUnits Unit { get; set; }
        public enum CyUnits { Year, Month, Week, Day };

        public override string ToString()
        {
            var buff = new StringBuilder();
            buff.Append(Interval);
            switch (Unit)
            {
                case CyUnits.Day: buff.Append("日"); break;
                case CyUnits.Month: buff.Append("月"); break;
                case CyUnits.Week: buff.Append("週"); break;
                case CyUnits.Year: buff.Append("年"); break;
            }
            return buff.Append("ごと").ToString();
        }
    }
}
