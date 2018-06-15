using System;
namespace Unclazz.Jp1ajs2.Schdls.Model
{
    public class FdParamData : ParamDataBase
    {
        public static FdParamData Create(string value)
        {
            return new FdParamData(value ?? throw new ArgumentNullException(nameof(value)));
        }

        FdParamData(string value) : base(value)
        {
            Minute = int.Parse(value);
        }

        public int Minute { get; }

        public override string ToString()
        {
            if (Minute % 60 == 0) return $"{Minute / 60}時間";
            if (Minute >= 60) return $"{Minute / 60}時間{Minute % 60}分";
            return $"{Minute}分";
        }
    }
}
