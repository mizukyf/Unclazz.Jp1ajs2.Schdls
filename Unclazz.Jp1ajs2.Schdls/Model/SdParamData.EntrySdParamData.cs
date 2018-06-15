namespace Unclazz.Jp1ajs2.Schdls.Model
{
    public abstract partial class SdParamData
    {
        public class EntrySdParamData : SdParamData
        {
            internal EntrySdParamData() : base("en") { }

            public override string ToString()
            {
                return "実行登録日";
            }
        }
    }

}
