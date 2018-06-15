using NUnit.Framework;
using Unclazz.Jp1ajs2.Schdls.Model;

namespace Test.Unclazz.Jp1ajs2.Schdls.Model
{
    public partial class SdParamDataTest
    {
        [TestFixture()]
        public class InverseDaySdParamDataTest
        {
            [Test()]
            public void Create_Case01_yyyymmdd()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("2018/06/b-01");
                var casted = pd as SdParamData.InverseDaySdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("2018/06/b-01"));
                Assert.That(casted.Year, Is.EqualTo(2018));
                Assert.That(casted.Month, Is.EqualTo(6));
                Assert.That(casted.Day, Is.EqualTo(-1));
                Assert.That(casted.Unit, Is.EqualTo(SdParamData.InverseDaySdParamData.DayUnits.Absolute));
                Assert.That(casted.ToString(), Is.EqualTo("2018年6月末の1日前"));
            }
            [Test()]
            public void Create_Case02_yyyymd()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("2018/6/b-10");
                var casted = pd as SdParamData.InverseDaySdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("2018/6/b-10"));
                Assert.That(casted.Year, Is.EqualTo(2018));
                Assert.That(casted.Month, Is.EqualTo(6));
                Assert.That(casted.Day, Is.EqualTo(-10));
                Assert.That(casted.Unit, Is.EqualTo(SdParamData.DaySdParamData.DayUnits.Absolute));
                Assert.That(casted.ToString(), Is.EqualTo("2018年6月末の10日前"));
            }
            [Test()]
            public void Create_Case11_yyyymmdd_plus()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("2018/06/+b-01");
                var casted = pd as SdParamData.InverseDaySdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("2018/06/+b-01"));
                Assert.That(casted.Year, Is.EqualTo(2018));
                Assert.That(casted.Month, Is.EqualTo(6));
                Assert.That(casted.Day, Is.EqualTo(-1));
                Assert.That(casted.Unit, Is.EqualTo(SdParamData.DaySdParamData.DayUnits.Relative));
                Assert.That(casted.ToString(), Is.EqualTo("2018年6月の相対日末日の1日前"));
            }
            [Test()]
            public void Create_Case12_yyyymd_plus()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("2018/6/+b-10");
                var casted = pd as SdParamData.InverseDaySdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("2018/6/+b-10"));
                Assert.That(casted.Year, Is.EqualTo(2018));
                Assert.That(casted.Month, Is.EqualTo(6));
                Assert.That(casted.Day, Is.EqualTo(-10));
                Assert.That(casted.Unit, Is.EqualTo(SdParamData.DaySdParamData.DayUnits.Relative));
                Assert.That(casted.ToString(), Is.EqualTo("2018年6月の相対日末日の10日前"));
            }
            [Test()]
            public void Create_Case21_yyyymmdd_star()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("2018/06/*b-01");
                var casted = pd as SdParamData.InverseDaySdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("2018/06/*b-01"));
                Assert.That(casted.Year, Is.EqualTo(2018));
                Assert.That(casted.Month, Is.EqualTo(6));
                Assert.That(casted.Day, Is.EqualTo(-1));
                Assert.That(casted.Unit, Is.EqualTo(SdParamData.DaySdParamData.DayUnits.BusinessDay));
                Assert.That(casted.ToString(), Is.EqualTo("2018年6月の運用日末日の1日前"));
            }
            [Test()]
            public void Create_Case22_yyyymd_star()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("2018/6/*b-10");
                var casted = pd as SdParamData.InverseDaySdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("2018/6/*b-10"));
                Assert.That(casted.Year, Is.EqualTo(2018));
                Assert.That(casted.Month, Is.EqualTo(6));
                Assert.That(casted.Day, Is.EqualTo(-10));
                Assert.That(casted.Unit, Is.EqualTo(SdParamData.DaySdParamData.DayUnits.BusinessDay));
                Assert.That(casted.ToString(), Is.EqualTo("2018年6月の運用日末日の10日前"));
            }
            [Test()]
            public void Create_Case31_yyyymmdd_at()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("2018/06/@b-01");
                var casted = pd as SdParamData.InverseDaySdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("2018/06/@b-01"));
                Assert.That(casted.Year, Is.EqualTo(2018));
                Assert.That(casted.Month, Is.EqualTo(6));
                Assert.That(casted.Day, Is.EqualTo(-1));
                Assert.That(casted.Unit, Is.EqualTo(SdParamData.DaySdParamData.DayUnits.NonBusinessDay));
                Assert.That(casted.ToString(), Is.EqualTo("2018年6月の休業日末日の1日前"));
            }
            [Test()]
            public void Create_Case32_yyyymd_at()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("2018/6/@b-10");
                var casted = pd as SdParamData.InverseDaySdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("2018/6/@b-10"));
                Assert.That(casted.Year, Is.EqualTo(2018));
                Assert.That(casted.Month, Is.EqualTo(6));
                Assert.That(casted.Day, Is.EqualTo(-10));
                Assert.That(casted.Unit, Is.EqualTo(SdParamData.DaySdParamData.DayUnits.NonBusinessDay));
                Assert.That(casted.ToString(), Is.EqualTo("2018年6月の休業日末日の10日前"));
            }
            [Test()]
            public void Create_Case41_mmdd()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("06/b-01");
                var casted = pd as SdParamData.InverseDaySdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("06/b-01"));
                Assert.That(casted.Year, Is.EqualTo(0));
                Assert.That(casted.Month, Is.EqualTo(6));
                Assert.That(casted.Day, Is.EqualTo(-1));
                Assert.That(casted.Unit, Is.EqualTo(SdParamData.DaySdParamData.DayUnits.Absolute));
                Assert.That(casted.ToString(), Is.EqualTo("6月末の1日前"));
            }
            [Test()]
            public void Create_Case42_md()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("6/b-10");
                var casted = pd as SdParamData.InverseDaySdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("6/b-10"));
                Assert.That(casted.Year, Is.EqualTo(0));
                Assert.That(casted.Month, Is.EqualTo(6));
                Assert.That(casted.Day, Is.EqualTo(-10));
                Assert.That(casted.Unit, Is.EqualTo(SdParamData.DaySdParamData.DayUnits.Absolute));
                Assert.That(casted.ToString(), Is.EqualTo("6月末の10日前"));
            }
            [Test()]
            public void Create_Case43_md_plus()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("6/+b-1");
                var casted = pd as SdParamData.InverseDaySdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("6/+b-1"));
                Assert.That(casted.Year, Is.EqualTo(0));
                Assert.That(casted.Month, Is.EqualTo(6));
                Assert.That(casted.Day, Is.EqualTo(-1));
                Assert.That(casted.Unit, Is.EqualTo(SdParamData.DaySdParamData.DayUnits.Relative));
                Assert.That(casted.ToString(), Is.EqualTo("6月の相対日末日の1日前"));
            }
            [Test()]
            public void Create_Case44_md_star()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("6/*b-10");
                var casted = pd as SdParamData.InverseDaySdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("6/*b-10"));
                Assert.That(casted.Year, Is.EqualTo(0));
                Assert.That(casted.Month, Is.EqualTo(6));
                Assert.That(casted.Day, Is.EqualTo(-10));
                Assert.That(casted.Unit, Is.EqualTo(SdParamData.DaySdParamData.DayUnits.BusinessDay));
                Assert.That(casted.ToString(), Is.EqualTo("6月の運用日末日の10日前"));
            }
            [Test()]
            public void Create_Case45_md_at()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("6/@b-1");
                var casted = pd as SdParamData.InverseDaySdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("6/@b-1"));
                Assert.That(casted.Year, Is.EqualTo(0));
                Assert.That(casted.Month, Is.EqualTo(6));
                Assert.That(casted.Day, Is.EqualTo(-1));
                Assert.That(casted.Unit, Is.EqualTo(SdParamData.DaySdParamData.DayUnits.NonBusinessDay));
                Assert.That(casted.ToString(), Is.EqualTo("6月の休業日末日の1日前"));
            }
            [Test()]
            public void Create_Case51_dd()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("b-01");
                var casted = pd as SdParamData.InverseDaySdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("b-01"));
                Assert.That(casted.Year, Is.EqualTo(0));
                Assert.That(casted.Month, Is.EqualTo(0));
                Assert.That(casted.Day, Is.EqualTo(-1));
                Assert.That(casted.Unit, Is.EqualTo(SdParamData.DaySdParamData.DayUnits.Absolute));
                Assert.That(casted.ToString(), Is.EqualTo("当月末の1日前"));
            }
            [Test()]
            public void Create_Case52_d()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("b-1");
                var casted = pd as SdParamData.InverseDaySdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("b-1"));
                Assert.That(casted.Year, Is.EqualTo(0));
                Assert.That(casted.Month, Is.EqualTo(0));
                Assert.That(casted.Day, Is.EqualTo(-1));
                Assert.That(casted.Unit, Is.EqualTo(SdParamData.DaySdParamData.DayUnits.Absolute));
                Assert.That(casted.ToString(), Is.EqualTo("当月末の1日前"));
            }
            [Test()]
            public void Create_Case53_d_plus()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("+b-1");
                var casted = pd as SdParamData.InverseDaySdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("+b-1"));
                Assert.That(casted.Year, Is.EqualTo(0));
                Assert.That(casted.Month, Is.EqualTo(0));
                Assert.That(casted.Day, Is.EqualTo(-1));
                Assert.That(casted.Unit, Is.EqualTo(SdParamData.DaySdParamData.DayUnits.Relative));
                Assert.That(casted.ToString(), Is.EqualTo("当月の相対日末日の1日前"));
            }
            [Test()]
            public void Create_Case54_d_star()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("*b-1");
                var casted = pd as SdParamData.InverseDaySdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("*b-1"));
                Assert.That(casted.Year, Is.EqualTo(0));
                Assert.That(casted.Month, Is.EqualTo(0));
                Assert.That(casted.Day, Is.EqualTo(-1));
                Assert.That(casted.Unit, Is.EqualTo(SdParamData.DaySdParamData.DayUnits.BusinessDay));
                Assert.That(casted.ToString(), Is.EqualTo("当月の運用日末日の1日前"));
            }
            [Test()]
            public void Create_Case55_d_at()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("@b-1");
                var casted = pd as SdParamData.InverseDaySdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("@b-1"));
                Assert.That(casted.Year, Is.EqualTo(0));
                Assert.That(casted.Month, Is.EqualTo(0));
                Assert.That(casted.Day, Is.EqualTo(-1));
                Assert.That(casted.Unit, Is.EqualTo(SdParamData.DaySdParamData.DayUnits.NonBusinessDay));
                Assert.That(casted.ToString(), Is.EqualTo("当月の休業日末日の1日前"));
            }
            [Test()]
            public void Create_Case61_yyyymmb()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("2018/06/b");
                var casted = pd as SdParamData.InverseDaySdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("2018/06/b"));
                Assert.That(casted.Year, Is.EqualTo(2018));
                Assert.That(casted.Month, Is.EqualTo(6));
                Assert.That(casted.Day, Is.EqualTo(0));
                Assert.That(casted.Unit, Is.EqualTo(SdParamData.InverseDaySdParamData.DayUnits.Absolute));
                Assert.That(casted.ToString(), Is.EqualTo("2018年6月末"));
            }
            [Test()]
            public void Create_Case62_mmb()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("06/b");
                var casted = pd as SdParamData.InverseDaySdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("06/b"));
                Assert.That(casted.Year, Is.EqualTo(0));
                Assert.That(casted.Month, Is.EqualTo(6));
                Assert.That(casted.Day, Is.EqualTo(0));
                Assert.That(casted.Unit, Is.EqualTo(SdParamData.InverseDaySdParamData.DayUnits.Absolute));
                Assert.That(casted.ToString(), Is.EqualTo("6月末"));
            }
            [Test()]
            public void Create_Case63_mmb()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("b");
                var casted = pd as SdParamData.InverseDaySdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("b"));
                Assert.That(casted.Year, Is.EqualTo(0));
                Assert.That(casted.Month, Is.EqualTo(0));
                Assert.That(casted.Day, Is.EqualTo(0));
                Assert.That(casted.Unit, Is.EqualTo(SdParamData.InverseDaySdParamData.DayUnits.Absolute));
                Assert.That(casted.ToString(), Is.EqualTo("当月末"));
            }
            [Test()]
            public void Create_Case71_yyyymmb_plus()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("2018/06/+b");
                var casted = pd as SdParamData.InverseDaySdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("2018/06/+b"));
                Assert.That(casted.Year, Is.EqualTo(2018));
                Assert.That(casted.Month, Is.EqualTo(6));
                Assert.That(casted.Day, Is.EqualTo(0));
                Assert.That(casted.Unit, Is.EqualTo(SdParamData.InverseDaySdParamData.DayUnits.Relative));
                Assert.That(casted.ToString(), Is.EqualTo("2018年6月の相対日末日"));
            }
            [Test()]
            public void Create_Case72_mmb_plus()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("06/+b");
                var casted = pd as SdParamData.InverseDaySdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("06/+b"));
                Assert.That(casted.Year, Is.EqualTo(0));
                Assert.That(casted.Month, Is.EqualTo(6));
                Assert.That(casted.Day, Is.EqualTo(0));
                Assert.That(casted.Unit, Is.EqualTo(SdParamData.InverseDaySdParamData.DayUnits.Relative));
                Assert.That(casted.ToString(), Is.EqualTo("6月の相対日末日"));
            }
            [Test()]
            public void Create_Case73_mmb_plus()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("+b");
                var casted = pd as SdParamData.InverseDaySdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("+b"));
                Assert.That(casted.Year, Is.EqualTo(0));
                Assert.That(casted.Month, Is.EqualTo(0));
                Assert.That(casted.Day, Is.EqualTo(0));
                Assert.That(casted.Unit, Is.EqualTo(SdParamData.InverseDaySdParamData.DayUnits.Relative));
                Assert.That(casted.ToString(), Is.EqualTo("当月の相対日末日"));
            }
        }
    }
}
