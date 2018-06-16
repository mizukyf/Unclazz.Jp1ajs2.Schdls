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
        public bool HasRunCondition => RunCondition != null && RunCondition.UnitTypes.Count > 0;
        public RunConditionData RunCondition { get; set; }
        public bool HasSubSchedules { get; set; }
        public IList<RuleData> ScheduleRules { get; } = new List<RuleData>();
        public EdParamData EdParam { get; set; }
        public FdParamData FdParam { get; set; }
    }
}
