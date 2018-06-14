using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Unclazz.Jp1ajs2.Schdls.Model
{
    public abstract class SdParamData
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
            var valueYyyy = values.Length == 3 ? int.Parse(values[2]) : 0;
            var valueMm = values.Length > 1 ? int.Parse(values[values.Length - 2]) : 0;
            var valueRest = values[values.Length - 1];

            var m0 = _re0.Match(valueRest);
            if (m0.Success)
            {
                return new InverseDaySdParamData(valueYyyy, valueMm, 
                       int.Parse(m0.Groups[2].Value), m0.Groups[1].Value);
            }

            var m1 = _re1.Match(valueRest);
            if (m1.Success)
            {
                var valueDd = m0.Groups[2].Value;
                var day = valueDd == string.Empty ? 0 : int.Parse(valueDd);
                return new DaySdParamData(valueYyyy, valueMm, day, m0.Groups[1].Value);
            }

            var m2 = _re2.Match(valueRest);
            if (m2.Success)
            {
                var rel = m2.Groups[1].Value == "+";
                var valueN = m2.Groups[4].Value;
                var num = valueN == string.Empty ? 0 : (valueN == "b" ? -1 : int.Parse(valueN));
                return new DayOfWeekSdParamData(valueYyyy, valueMm, m2.Groups[2].Value, num, rel);
            }

            throw new ArgumentException($"unknown value '{value}'.");
        }

        public static SdParamData Default { get; } = _en;
    }

    class DayOfWeekSdParamData : YearMonthSdParamData
    {
        internal DayOfWeekSdParamData(int year, int month, string dayOfWeek, int num, bool relative) : base(year, month)
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

    class InverseDaySdParamData : DaySdParamData
    {
        internal InverseDaySdParamData(int year, int month, int day, string unit)
            : base(year, month, day, unit)
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

    class DaySdParamData : YearMonthSdParamData
    {
        internal DaySdParamData(int year, int month, int day, string unit) : base(year, month)
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

    abstract class YearMonthSdParamData : SdParamData
    {
        internal YearMonthSdParamData(int year, int month)
        {
            Year = year;
            Month = month;
        }

        public int Year { get; }
        public int Month { get; }
    }

    class EntrySdParamData : SdParamData
    {
        public override string ToString()
        {
            return "実行登録日";
        }
    }

    class UndefinedSdParamData : SdParamData
    {
        public override string ToString()
        {
            return "スケジュール未定義";
        }
    }
}
