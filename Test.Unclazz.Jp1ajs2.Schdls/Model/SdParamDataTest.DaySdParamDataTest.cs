using NUnit.Framework;
using Unclazz.Jp1ajs2.Schdls.Model;

namespace Test.Unclazz.Jp1ajs2.Schdls.Model
{
    public partial class SdParamDataTest
    {
        [TestFixture()]
        public class DaySdParamDataTest
        {
            [Test()]
            public void Create_Case01_yyyymmdd()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("2018/06/01");
                var casted = pd as SdParamData.DaySdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("2018/06/01"));
                Assert.That(casted.Year, Is.EqualTo(2018));
                Assert.That(casted.Month, Is.EqualTo(6));
                Assert.That(casted.Day, Is.EqualTo(1));
                Assert.That(casted.Unit, Is.EqualTo(SdParamData.DaySdParamData.DayUnits.Absolute));
            }
            [Test()]
            public void Create_Case02_yyyymd()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("2018/6/1");
                var casted = pd as SdParamData.DaySdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("2018/6/1"));
                Assert.That(casted.Year, Is.EqualTo(2018));
                Assert.That(casted.Month, Is.EqualTo(6));
                Assert.That(casted.Day, Is.EqualTo(1));
                Assert.That(casted.Unit, Is.EqualTo(SdParamData.DaySdParamData.DayUnits.Absolute));
            }
            [Test()]
            public void Create_Case11_yyyymmdd_plus()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("2018/06/+01");
                var casted = pd as SdParamData.DaySdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("2018/06/+01"));
                Assert.That(casted.Year, Is.EqualTo(2018));
                Assert.That(casted.Month, Is.EqualTo(6));
                Assert.That(casted.Day, Is.EqualTo(1));
                Assert.That(casted.Unit, Is.EqualTo(SdParamData.DaySdParamData.DayUnits.Relative));
            }
            [Test()]
            public void Create_Case12_yyyymd_plus()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("2018/6/+1");
                var casted = pd as SdParamData.DaySdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("2018/6/+1"));
                Assert.That(casted.Year, Is.EqualTo(2018));
                Assert.That(casted.Month, Is.EqualTo(6));
                Assert.That(casted.Day, Is.EqualTo(1));
                Assert.That(casted.Unit, Is.EqualTo(SdParamData.DaySdParamData.DayUnits.Relative));
            }
            [Test()]
            public void Create_Case21_yyyymmdd_star()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("2018/06/*01");
                var casted = pd as SdParamData.DaySdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("2018/06/*01"));
                Assert.That(casted.Year, Is.EqualTo(2018));
                Assert.That(casted.Month, Is.EqualTo(6));
                Assert.That(casted.Day, Is.EqualTo(1));
                Assert.That(casted.Unit, Is.EqualTo(SdParamData.DaySdParamData.DayUnits.BusinessDay));
            }
            [Test()]
            public void Create_Case22_yyyymd_star()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("2018/6/*1");
                var casted = pd as SdParamData.DaySdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("2018/6/*1"));
                Assert.That(casted.Year, Is.EqualTo(2018));
                Assert.That(casted.Month, Is.EqualTo(6));
                Assert.That(casted.Day, Is.EqualTo(1));
                Assert.That(casted.Unit, Is.EqualTo(SdParamData.DaySdParamData.DayUnits.BusinessDay));
            }
            [Test()]
            public void Create_Case31_yyyymmdd_at()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("2018/06/@01");
                var casted = pd as SdParamData.DaySdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("2018/06/@01"));
                Assert.That(casted.Year, Is.EqualTo(2018));
                Assert.That(casted.Month, Is.EqualTo(6));
                Assert.That(casted.Day, Is.EqualTo(1));
                Assert.That(casted.Unit, Is.EqualTo(SdParamData.DaySdParamData.DayUnits.NonBusinessDay));
            }
            [Test()]
            public void Create_Case32_yyyymd_at()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("2018/6/@1");
                var casted = pd as SdParamData.DaySdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("2018/6/@1"));
                Assert.That(casted.Year, Is.EqualTo(2018));
                Assert.That(casted.Month, Is.EqualTo(6));
                Assert.That(casted.Day, Is.EqualTo(1));
                Assert.That(casted.Unit, Is.EqualTo(SdParamData.DaySdParamData.DayUnits.NonBusinessDay));
            }
            [Test()]
            public void Create_Case41_mmdd()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("06/01");
                var casted = pd as SdParamData.DaySdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("06/01"));
                Assert.That(casted.Year, Is.EqualTo(0));
                Assert.That(casted.Month, Is.EqualTo(6));
                Assert.That(casted.Day, Is.EqualTo(1));
                Assert.That(casted.Unit, Is.EqualTo(SdParamData.DaySdParamData.DayUnits.Absolute));
            }
            [Test()]
            public void Create_Case42_md()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("6/1");
                var casted = pd as SdParamData.DaySdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("6/1"));
                Assert.That(casted.Year, Is.EqualTo(0));
                Assert.That(casted.Month, Is.EqualTo(6));
                Assert.That(casted.Day, Is.EqualTo(1));
                Assert.That(casted.Unit, Is.EqualTo(SdParamData.DaySdParamData.DayUnits.Absolute));
            }
            [Test()]
            public void Create_Case43_md_plus()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("6/+1");
                var casted = pd as SdParamData.DaySdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("6/+1"));
                Assert.That(casted.Year, Is.EqualTo(0));
                Assert.That(casted.Month, Is.EqualTo(6));
                Assert.That(casted.Day, Is.EqualTo(1));
                Assert.That(casted.Unit, Is.EqualTo(SdParamData.DaySdParamData.DayUnits.Relative));
            }
            [Test()]
            public void Create_Case44_md_star()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("6/*1");
                var casted = pd as SdParamData.DaySdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("6/*1"));
                Assert.That(casted.Year, Is.EqualTo(0));
                Assert.That(casted.Month, Is.EqualTo(6));
                Assert.That(casted.Day, Is.EqualTo(1));
                Assert.That(casted.Unit, Is.EqualTo(SdParamData.DaySdParamData.DayUnits.BusinessDay));
            }
            [Test()]
            public void Create_Case45_md_at()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("6/@1");
                var casted = pd as SdParamData.DaySdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("6/@1"));
                Assert.That(casted.Year, Is.EqualTo(0));
                Assert.That(casted.Month, Is.EqualTo(6));
                Assert.That(casted.Day, Is.EqualTo(1));
                Assert.That(casted.Unit, Is.EqualTo(SdParamData.DaySdParamData.DayUnits.NonBusinessDay));
            }
            [Test()]
            public void Create_Case51_dd()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("01");
                var casted = pd as SdParamData.DaySdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("01"));
                Assert.That(casted.Year, Is.EqualTo(0));
                Assert.That(casted.Month, Is.EqualTo(0));
                Assert.That(casted.Day, Is.EqualTo(1));
                Assert.That(casted.Unit, Is.EqualTo(SdParamData.DaySdParamData.DayUnits.Absolute));
            }
            [Test()]
            public void Create_Case52_d()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("1");
                var casted = pd as SdParamData.DaySdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("1"));
                Assert.That(casted.Year, Is.EqualTo(0));
                Assert.That(casted.Month, Is.EqualTo(0));
                Assert.That(casted.Day, Is.EqualTo(1));
                Assert.That(casted.Unit, Is.EqualTo(SdParamData.DaySdParamData.DayUnits.Absolute));
            }
            [Test()]
            public void Create_Case53_d_plus()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("+1");
                var casted = pd as SdParamData.DaySdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("+1"));
                Assert.That(casted.Year, Is.EqualTo(0));
                Assert.That(casted.Month, Is.EqualTo(0));
                Assert.That(casted.Day, Is.EqualTo(1));
                Assert.That(casted.Unit, Is.EqualTo(SdParamData.DaySdParamData.DayUnits.Relative));
            }
            [Test()]
            public void Create_Case54_d_star()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("*1");
                var casted = pd as SdParamData.DaySdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("*1"));
                Assert.That(casted.Year, Is.EqualTo(0));
                Assert.That(casted.Month, Is.EqualTo(0));
                Assert.That(casted.Day, Is.EqualTo(1));
                Assert.That(casted.Unit, Is.EqualTo(SdParamData.DaySdParamData.DayUnits.BusinessDay));
            }
            [Test()]
            public void Create_Case55_d_at()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("@1");
                var casted = pd as SdParamData.DaySdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("@1"));
                Assert.That(casted.Year, Is.EqualTo(0));
                Assert.That(casted.Month, Is.EqualTo(0));
                Assert.That(casted.Day, Is.EqualTo(1));
                Assert.That(casted.Unit, Is.EqualTo(SdParamData.DaySdParamData.DayUnits.NonBusinessDay));
            }
        }
    }
}
