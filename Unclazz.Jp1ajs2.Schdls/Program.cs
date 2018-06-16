using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Unclazz.Jp1ajs2.Schdls.Model;
using Unclazz.Jp1ajs2.Unitdef;

namespace Unclazz.Jp1ajs2.Schdls
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("USAGE: JP1SCHDLS.EXE ファイル名 [エンコード名]");
                Environment.Exit(0);
            }
            try {
                new MainClass().Execute(args[0], args.Length > 1 
                ? Encoding.GetEncoding(args[1]) : Encoding.Default);
                Environment.Exit(0);
            } 
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
                Environment.Exit(1);
            }
        }

        public void Execute(string path, Encoding encoding)
        {
            var root = Unit.FromFile(path, encoding);
            var targets = root.Type == UnitType.Jobnet ? new IUnit[] { root }
                : root.ItSelfAndDescendants(UnitType.JobGroup).TheirChildren(UnitType.Jobnet);

            WriteLine("完全名", "コメント", "サイズ", "実行所要時間", 
                      "起動条件", "起動条件種別", "下位ユニットのスケジュール",
                      "ルール番号", "開始日", "開始時刻",
                      "サイクル実行", "回数制限", "時刻制限");

            foreach (var target in targets)
            {
                var data = ExtractData(target);

                foreach (var ruleData in data.ScheduleRules)
                {
                    WriteLine(
                        data.FullName, data.Comment, data.Size, data.FdParam,
                        data.HasRunCondition ? "あり" : "なし", data.RunCondition, data.HasSubSchedules ? "あり" : "なし",
                        ruleData.Number, ruleData.SdParam, ruleData.StParam,
                        ruleData.CyParam, ruleData.WcParam, ruleData.WtParam
                    );
                }
            }
        }

        void WriteLine(params object[] values)
        {
            var first = true;
            foreach (var value in values)
            {
                if (first) first = false;
                else Console.Write('\t');
                Console.Write(value);
            }
            Console.WriteLine();
        }

        public JobnetData ExtractData(IUnit jobnet)
        {
            var data = new JobnetData();
            data.FullName = jobnet.FullName;
            data.Comment = jobnet.Comment;
            data.Size = jobnet.ItSelfAndDescendants().Count();
                                
            var edParam = jobnet.Parameters.FirstOrDefault("ed");
            if (edParam != null)
            {
                data.EdParam = EdParamData.Create(edParam.Values[0].StringValue);
            }

            var fdParam = jobnet.Parameters.FirstOrDefault("fd");
            if (fdParam != null)
            {
                data.FdParam = FdParamData.Create(fdParam.Values[0].StringValue);
            }
                                
            data.RunCondition = RunConditionData.Create(jobnet.
            Children(UnitType.RunCondition).TheirChildren().Select(x => x.Type));

            data.HasSubSchedules = jobnet.Descendants(UnitType.Jobnet).HasParameter("sd").Any();

            foreach (var rule in ExtractRuleData(jobnet))
            {
                data.ScheduleRules.Add(rule);
            }

            return data;
        }

        public IEnumerable<RuleData> ExtractRuleData(IUnit jobnet)
        {
            foreach (var sdParam in jobnet.Parameters.Where(x => x.Name == "sd"))
            {
                var d = new RuleData();

                d.Number = sdParam.Values.Count == 1 ? 1 : int.Parse(sdParam.Values[0].StringValue);
                d.SdParam = SdParamData.Create(sdParam.Values[sdParam.Values.Count - 1].StringValue);
                d.StParam = jobnet.ParameterNvl("st", d.Number, x => StParamData.Create(x.StringValue), StParamData.Default);
                d.CyParam = jobnet.ParameterNvl("cy", d.Number, x => CyParamData.Create(x.TupleValue), null);
                d.WcParam = jobnet.ParameterNvl("wc", d.Number, x => WcParamData.Create(x.StringValue), WcParamData.Default);
                d.WtParam = jobnet.ParameterNvl("wt", d.Number, x => WtParamData.Create(x.StringValue), WtParamData.Default);

                yield return d;
            }
        }
    }
}
