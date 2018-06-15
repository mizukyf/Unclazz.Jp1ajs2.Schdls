using NUnit.Framework;
using Unclazz.Jp1ajs2.Schdls.Model;

namespace Test.Unclazz.Jp1ajs2.Schdls.Model
{
    [TestFixture()]
    public class EdParamDataTest
    {
        [Test()]
        public void Create_Case01_yyyymmdd()
        {
            // Arrange
            // Act
            var pd = EdParamData.Create("2018/06/15");

            // Assert
            Assert.That(pd.RawData, Is.EqualTo("2018/06/15"));
            Assert.That(pd.Year, Is.EqualTo(2018));
            Assert.That(pd.Month, Is.EqualTo(6));
            Assert.That(pd.Day, Is.EqualTo(15));
            Assert.That(pd.ToString(), Is.EqualTo("2018年6月15日"));
        }
        [Test()]
        public void Create_Case02_yyyymmdd()
        {
            // Arrange
            // Act
            var pd = EdParamData.Create("2018/06/01");

            // Assert
            Assert.That(pd.RawData, Is.EqualTo("2018/06/01"));
            Assert.That(pd.Year, Is.EqualTo(2018));
            Assert.That(pd.Month, Is.EqualTo(6));
            Assert.That(pd.Day, Is.EqualTo(1));
            Assert.That(pd.ToString(), Is.EqualTo("2018年6月1日"));
        }
        [Test()]
        public void Create_Case11_yyyymdd()
        {
            // Arrange
            // Act
            var pd = EdParamData.Create("2018/6/15");

            // Assert
            Assert.That(pd.RawData, Is.EqualTo("2018/6/15"));
            Assert.That(pd.Year, Is.EqualTo(2018));
            Assert.That(pd.Month, Is.EqualTo(6));
            Assert.That(pd.Day, Is.EqualTo(15));
            Assert.That(pd.ToString(), Is.EqualTo("2018年6月15日"));
        }
        [Test()]
        public void Create_Case22_yyyymmd()
        {
            // Arrange
            // Act
            var pd = EdParamData.Create("2018/06/1");

            // Assert
            Assert.That(pd.RawData, Is.EqualTo("2018/06/1"));
            Assert.That(pd.Year, Is.EqualTo(2018));
            Assert.That(pd.Month, Is.EqualTo(6));
            Assert.That(pd.Day, Is.EqualTo(1));
            Assert.That(pd.ToString(), Is.EqualTo("2018年6月1日"));
        }

    }
}
