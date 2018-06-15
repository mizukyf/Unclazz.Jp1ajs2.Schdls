using NUnit.Framework;
using Unclazz.Jp1ajs2.Schdls.Model;

namespace Test.Unclazz.Jp1ajs2.Schdls.Model
{
    [TestFixture()]
    public class StParamDataTest
    {
        [Test()]
        public void Create_Case01_hhmm()
        {
            // Arrange
            // Act
            var pd = StParamData.Create("00:30");

            // Assert
            Assert.That(pd.RawData, Is.EqualTo("00:30"));
            Assert.That(pd.Hour, Is.EqualTo(0));
            Assert.That(pd.Minute, Is.EqualTo(30));
            Assert.That(pd.Relative, Is.False);
            Assert.That(pd.ToString(), Is.EqualTo("絶対時刻0時30分"));
        }
        [Test()]
        public void Create_Case02_hhmm()
        {
            // Arrange
            // Act
            var pd = StParamData.Create("01:30");

            // Assert
            Assert.That(pd.RawData, Is.EqualTo("01:30"));
            Assert.That(pd.Hour, Is.EqualTo(1));
            Assert.That(pd.Minute, Is.EqualTo(30));
            Assert.That(pd.Relative, Is.False);
            Assert.That(pd.ToString(), Is.EqualTo("絶対時刻1時30分"));
        }
        [Test()]
        public void Create_Case03_hhmm()
        {
            // Arrange
            // Act
            var pd = StParamData.Create("02:15");

            // Assert
            Assert.That(pd.RawData, Is.EqualTo("02:15"));
            Assert.That(pd.Hour, Is.EqualTo(2));
            Assert.That(pd.Minute, Is.EqualTo(15));
            Assert.That(pd.Relative, Is.False);
            Assert.That(pd.ToString(), Is.EqualTo("絶対時刻2時15分"));
        }
        [Test()]
        public void Create_Case04_hhmm()
        {
            // Arrange
            // Act
            var pd = StParamData.Create("0:05");

            // Assert
            Assert.That(pd.RawData, Is.EqualTo("0:05"));
            Assert.That(pd.Hour, Is.EqualTo(0));
            Assert.That(pd.Minute, Is.EqualTo(5));
            Assert.That(pd.Relative, Is.False);
            Assert.That(pd.ToString(), Is.EqualTo("絶対時刻0時5分"));
        }
        [Test()]
        public void Create_Case11_hhmm()
        {
            // Arrange
            // Act
            var pd = StParamData.Create("+00:30");

            // Assert
            Assert.That(pd.RawData, Is.EqualTo("+00:30"));
            Assert.That(pd.Hour, Is.EqualTo(0));
            Assert.That(pd.Minute, Is.EqualTo(30));
            Assert.That(pd.Relative, Is.True);
            Assert.That(pd.ToString(), Is.EqualTo("相対時刻0時30分"));
        }
        [Test()]
        public void Create_Case12_hhmm()
        {
            // Arrange
            // Act
            var pd = StParamData.Create("+01:30");

            // Assert
            Assert.That(pd.RawData, Is.EqualTo("+01:30"));
            Assert.That(pd.Hour, Is.EqualTo(1));
            Assert.That(pd.Minute, Is.EqualTo(30));
            Assert.That(pd.Relative, Is.True);
            Assert.That(pd.ToString(), Is.EqualTo("相対時刻1時30分"));
        }
        [Test()]
        public void Create_Case13_hhmm()
        {
            // Arrange
            // Act
            var pd = StParamData.Create("+02:15");

            // Assert
            Assert.That(pd.RawData, Is.EqualTo("+02:15"));
            Assert.That(pd.Hour, Is.EqualTo(2));
            Assert.That(pd.Minute, Is.EqualTo(15));
            Assert.That(pd.Relative, Is.True);
            Assert.That(pd.ToString(), Is.EqualTo("相対時刻2時15分"));
        }
        [Test()]
        public void Create_Case14_hhmm()
        {
            // Arrange
            // Act
            var pd = StParamData.Create("+0:05");

            // Assert
            Assert.That(pd.RawData, Is.EqualTo("+0:05"));
            Assert.That(pd.Hour, Is.EqualTo(0));
            Assert.That(pd.Minute, Is.EqualTo(5));
            Assert.That(pd.Relative, Is.True);
            Assert.That(pd.ToString(), Is.EqualTo("相対時刻0時5分"));
        }

    }
}
