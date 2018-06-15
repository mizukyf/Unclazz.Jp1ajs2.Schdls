using NUnit.Framework;
using Unclazz.Jp1ajs2.Schdls.Model;

namespace Test.Unclazz.Jp1ajs2.Schdls.Model
{
    [TestFixture()]
    public class FdParamDataTest
    {
        [Test()]
        public void Create_Case01_1()
        {
            // Arrange
            // Act
            var pd = FdParamData.Create("1");

            // Assert
            Assert.That(pd.RawData, Is.EqualTo("1"));
            Assert.That(pd.Minute, Is.EqualTo(1));
            Assert.That(pd.ToString(), Is.EqualTo("1分"));
        }
        [Test()]
        public void Create_Case02_59()
        {
            // Arrange
            // Act
            var pd = FdParamData.Create("59");

            // Assert
            Assert.That(pd.RawData, Is.EqualTo("59"));
            Assert.That(pd.Minute, Is.EqualTo(59));
            Assert.That(pd.ToString(), Is.EqualTo("59分"));
        }
        [Test()]
        public void Create_Case03_60()
        {
            // Arrange
            // Act
            var pd = FdParamData.Create("60");

            // Assert
            Assert.That(pd.RawData, Is.EqualTo("60"));
            Assert.That(pd.Minute, Is.EqualTo(60));
            Assert.That(pd.ToString(), Is.EqualTo("1時間"));
        }
        [Test()]
        public void Create_Case04_61()
        {
            // Arrange
            // Act
            var pd = FdParamData.Create("61");

            // Assert
            Assert.That(pd.RawData, Is.EqualTo("61"));
            Assert.That(pd.Minute, Is.EqualTo(61));
            Assert.That(pd.ToString(), Is.EqualTo("1時間1分"));
        }
        [Test()]
        public void Create_Case05_119()
        {
            // Arrange
            // Act
            var pd = FdParamData.Create("119");

            // Assert
            Assert.That(pd.RawData, Is.EqualTo("119"));
            Assert.That(pd.Minute, Is.EqualTo(119));
            Assert.That(pd.ToString(), Is.EqualTo("1時間59分"));
        }
        [Test()]
        public void Create_Case06_121()
        {
            // Arrange
            // Act
            var pd = FdParamData.Create("121");

            // Assert
            Assert.That(pd.RawData, Is.EqualTo("121"));
            Assert.That(pd.Minute, Is.EqualTo(121));
            Assert.That(pd.ToString(), Is.EqualTo("2時間1分"));
        }
    }
}
