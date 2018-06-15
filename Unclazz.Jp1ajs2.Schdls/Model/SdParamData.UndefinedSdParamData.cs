namespace Unclazz.Jp1ajs2.Schdls.Model
{
    public abstract partial class SdParamData
    {
        public class UndefinedSdParamData : SdParamData
        {
            internal UndefinedSdParamData() : base("ud") { }

            public override string ToString()
            {
                return "スケジュール未定義";
            }
        }
    }

}
