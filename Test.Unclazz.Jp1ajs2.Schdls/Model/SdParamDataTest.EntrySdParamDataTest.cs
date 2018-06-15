using NUnit.Framework;
using Unclazz.Jp1ajs2.Schdls.Model;

namespace Test.Unclazz.Jp1ajs2.Schdls.Model
{
    public partial class SdParamDataTest
    {
        [TestFixture()]
        public class EntrySdParamDataTest
        {
            [Test()]
            public void Create_Case01_en()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("en");

                // Assert
                Assert.That(pd.RawData, Is.EqualTo("en"));
                Assert.That(pd, Is.InstanceOf<SdParamData.EntrySdParamData>());
            }
        }
    }
}
