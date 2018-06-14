using System;
using System.Collections.Generic;
using Unclazz.Jp1ajs2.Unitdef;

namespace Unclazz.Jp1ajs2.Schdls.Model
{
    public class JobnetData
    {
        public FullName FullName { get; set; }
        public string Comment { get; set; }
        public int Size { get; set; }
        public bool HasRunCondition { get; set; }
        public IList<UnitType> RunConditions { get; } = new List<UnitType>();
        public bool HasSubSchedules { get; set; }
        public IList<RuleData> ScheduleRules { get; } = new List<RuleData>();
        public EdParamData EdParam { get; }
        public int FixedDuration { get; }
    }
}
