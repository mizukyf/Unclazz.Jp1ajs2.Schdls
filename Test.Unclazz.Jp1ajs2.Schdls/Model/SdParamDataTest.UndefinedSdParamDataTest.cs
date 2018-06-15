using NUnit.Framework;
using Unclazz.Jp1ajs2.Schdls.Model;

namespace Test.Unclazz.Jp1ajs2.Schdls.Model
{
    public partial class SdParamDataTest
    {
        [TestFixture()]
        public class UndefinedSdParamDataTest
        {
            [Test()]
            public void Create_Case01_ud()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("ud");

                // Assert
                Assert.That(pd.RawData, Is.EqualTo("ud"));
                Assert.That(pd, Is.InstanceOf<SdParamData.UndefinedSdParamData>());
            }
        }
    }
}
