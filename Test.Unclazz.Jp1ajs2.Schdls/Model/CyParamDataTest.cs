using NUnit.Framework;
using Unclazz.Jp1ajs2.Schdls.Model;
using Unclazz.Jp1ajs2.Unitdef;

namespace Test.Unclazz.Jp1ajs2.Schdls.Model
{
    [TestFixture()]
    public class CyParamDataTest
    {
        [Test()]
        public void Create_Case01_1_y()
        {
            // Arrange
            var tpl = MutableTuple.Empty;
            tpl.Add("1");
            tpl.Add("y");

            // Act
            var pd = CyParamData.Create(tpl);

            // Assert
            Assert.That(pd.RawData, Is.EqualTo("(1,y)"));
            Assert.That(pd.Interval, Is.EqualTo(1));
            Assert.That(pd.Unit, Is.EqualTo(CyParamData.CyUnits.Year));
            Assert.That(pd.ToString(), Is.EqualTo("1年ごと"));
        }
        [Test()]
        public void Create_Case02_10_y()
        {
            // Arrange
            var tpl = MutableTuple.Empty;
            tpl.Add("10");
            tpl.Add("y");

            // Act
            var pd = CyParamData.Create(tpl);

            // Assert
            Assert.That(pd.RawData, Is.EqualTo("(10,y)"));
            Assert.That(pd.Interval, Is.EqualTo(10));
            Assert.That(pd.Unit, Is.EqualTo(CyParamData.CyUnits.Year));
            Assert.That(pd.ToString(), Is.EqualTo("10年ごと"));
        }
        [Test()]
        public void Create_Case11_1_m()
        {
            // Arrange
            var tpl = MutableTuple.Empty;
            tpl.Add("1");
            tpl.Add("m");

            // Act
            var pd = CyParamData.Create(tpl);

            // Assert
            Assert.That(pd.RawData, Is.EqualTo("(1,m)"));
            Assert.That(pd.Interval, Is.EqualTo(1));
            Assert.That(pd.Unit, Is.EqualTo(CyParamData.CyUnits.Month));
            Assert.That(pd.ToString(), Is.EqualTo("1ヶ月ごと"));
        }
        [Test()]
        public void Create_Case12_10_m()
        {
            // Arrange
            var tpl = MutableTuple.Empty;
            tpl.Add("10");
            tpl.Add("m");

            // Act
            var pd = CyParamData.Create(tpl);

            // Assert
            Assert.That(pd.RawData, Is.EqualTo("(10,m)"));
            Assert.That(pd.Interval, Is.EqualTo(10));
            Assert.That(pd.Unit, Is.EqualTo(CyParamData.CyUnits.Month));
            Assert.That(pd.ToString(), Is.EqualTo("10ヶ月ごと"));
        }
        [Test()]
        public void Create_Case21_1_w()
        {
            // Arrange
            var tpl = MutableTuple.Empty;
            tpl.Add("1");
            tpl.Add("w");

            // Act
            var pd = CyParamData.Create(tpl);

            // Assert
            Assert.That(pd.RawData, Is.EqualTo("(1,w)"));
            Assert.That(pd.Interval, Is.EqualTo(1));
            Assert.That(pd.Unit, Is.EqualTo(CyParamData.CyUnits.Week));
            Assert.That(pd.ToString(), Is.EqualTo("1週間ごと"));
        }
        [Test()]
        public void Create_Case22_10_w()
        {
            // Arrange
            var tpl = MutableTuple.Empty;
            tpl.Add("10");
            tpl.Add("w");

            // Act
            var pd = CyParamData.Create(tpl);

            // Assert
            Assert.That(pd.RawData, Is.EqualTo("(10,w)"));
            Assert.That(pd.Interval, Is.EqualTo(10));
            Assert.That(pd.Unit, Is.EqualTo(CyParamData.CyUnits.Week));
            Assert.That(pd.ToString(), Is.EqualTo("10週間ごと"));
        }
        [Test()]
        public void Create_Case31_1_d()
        {
            // Arrange
            var tpl = MutableTuple.Empty;
            tpl.Add("1");
            tpl.Add("d");

            // Act
            var pd = CyParamData.Create(tpl);

            // Assert
            Assert.That(pd.RawData, Is.EqualTo("(1,d)"));
            Assert.That(pd.Interval, Is.EqualTo(1));
            Assert.That(pd.Unit, Is.EqualTo(CyParamData.CyUnits.Day));
            Assert.That(pd.ToString(), Is.EqualTo("1日ごと"));
        }
        [Test()]
        public void Create_Case32_10_d()
        {
            // Arrange
            var tpl = MutableTuple.Empty;
            tpl.Add("10");
            tpl.Add("d");

            // Act
            var pd = CyParamData.Create(tpl);

            // Assert
            Assert.That(pd.RawData, Is.EqualTo("(10,d)"));
            Assert.That(pd.Interval, Is.EqualTo(10));
            Assert.That(pd.Unit, Is.EqualTo(CyParamData.CyUnits.Day));
            Assert.That(pd.ToString(), Is.EqualTo("10日ごと"));
        }

    }
}
