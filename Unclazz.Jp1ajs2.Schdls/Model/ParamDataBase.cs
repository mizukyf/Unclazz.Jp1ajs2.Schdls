using System;
namespace Unclazz.Jp1ajs2.Schdls.Model
{
    public abstract class ParamDataBase
    {
        public ParamDataBase(string value)
        {
            RawData = value;
        }

        public string RawData { get; }
    }
}
