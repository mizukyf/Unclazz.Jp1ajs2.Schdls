using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Unclazz.Jp1ajs2.Unitdef;

namespace Unclazz.Jp1ajs2.Schdls.Model
{
    public class RunConditionData
    {
        public static RunConditionData Create(IEnumerable<UnitType> values)
        {
            return new RunConditionData(values ?? throw new ArgumentNullException(nameof(values)));
        }

        RunConditionData(IEnumerable<UnitType> values)
        {
            UnitTypes = values.ToList().AsReadOnly();
        }

        public IList<UnitType> UnitTypes { get; }

        public override string ToString()
        {
            var buff = new StringBuilder();

            foreach (var type in UnitTypes)
            {
                if (buff.Length > 0) buff.Append(",");
                else if (type == UnitType.EventWatchJob) buff.Append("JP1イベント受信");
                else if (type == UnitType.FileWatchJob) buff.Append("ファイル監視");
                else if (type == UnitType.LogFileWatchJob) buff.Append("ログファイル監視");
                else if (type == UnitType.WindowsEventLogWatchJob) buff.Append("Windowsイベントログ監視");
                else if (type == UnitType.TimeWatchJob) buff.Append("実行間隔制御");
                else if (type == UnitType.MailWatchJob) buff.Append("メール受信");
                else if (type == UnitType.MessageQueueWatchJob) buff.Append("メッセージキュー受信");
                else if (type == UnitType.MsmqWatchJob) buff.Append("MSMQ受信");
            }
            return buff.ToString();
        }
    }
}
