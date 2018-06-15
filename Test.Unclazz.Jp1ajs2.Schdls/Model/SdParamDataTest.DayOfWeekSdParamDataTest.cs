using System;
using NUnit.Framework;
using Unclazz.Jp1ajs2.Schdls.Model;

namespace Test.Unclazz.Jp1ajs2.Schdls.Model
{
    public partial class SdParamDataTest
    {
        [TestFixture()]
        public class DayOfWeekSdParamDataTest
        {
            [Test()]
            public void Create_Case01_yyyymm_su()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("2018/06/su");
                var casted = pd as SdParamData.DayOfWeekSdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("2018/06/su"));
                Assert.That(casted.Year, Is.EqualTo(2018));
                Assert.That(casted.Month, Is.EqualTo(6));
                Assert.That(casted.DayOfWeek, Is.EqualTo(DayOfWeek.Sunday));
                Assert.That(casted.Relative, Is.False);
                Assert.That(casted.Number, Is.EqualTo(0));
                Assert.That(casted.ToString(), Is.EqualTo("2018年6月第1日曜日"));
            }
            [Test()]
            public void Create_Case02_yyyymm_mo()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("2018/06/mo");
                var casted = pd as SdParamData.DayOfWeekSdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("2018/06/mo"));
                Assert.That(casted.Year, Is.EqualTo(2018));
                Assert.That(casted.Month, Is.EqualTo(6));
                Assert.That(casted.DayOfWeek, Is.EqualTo(DayOfWeek.Monday));
                Assert.That(casted.Relative, Is.False);
                Assert.That(casted.Number, Is.EqualTo(0));
                Assert.That(casted.ToString(), Is.EqualTo("2018年6月第1月曜日"));
            }
            [Test()]
            public void Create_Case03_yyyymm_tu()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("2018/06/tu");
                var casted = pd as SdParamData.DayOfWeekSdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("2018/06/tu"));
                Assert.That(casted.Year, Is.EqualTo(2018));
                Assert.That(casted.Month, Is.EqualTo(6));
                Assert.That(casted.DayOfWeek, Is.EqualTo(DayOfWeek.Tuesday));
                Assert.That(casted.Relative, Is.False);
                Assert.That(casted.Number, Is.EqualTo(0));
                Assert.That(casted.ToString(), Is.EqualTo("2018年6月第1火曜日"));
            }
            [Test()]
            public void Create_Case04_yyyymm_we()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("2018/06/we");
                var casted = pd as SdParamData.DayOfWeekSdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("2018/06/we"));
                Assert.That(casted.Year, Is.EqualTo(2018));
                Assert.That(casted.Month, Is.EqualTo(6));
                Assert.That(casted.DayOfWeek, Is.EqualTo(DayOfWeek.Wednesday));
                Assert.That(casted.Relative, Is.False);
                Assert.That(casted.Number, Is.EqualTo(0));
                Assert.That(casted.ToString(), Is.EqualTo("2018年6月第1水曜日"));
            }
            [Test()]
            public void Create_Case05_yyyymm_th()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("2018/06/th");
                var casted = pd as SdParamData.DayOfWeekSdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("2018/06/th"));
                Assert.That(casted.Year, Is.EqualTo(2018));
                Assert.That(casted.Month, Is.EqualTo(6));
                Assert.That(casted.DayOfWeek, Is.EqualTo(DayOfWeek.Thursday));
                Assert.That(casted.Relative, Is.False);
                Assert.That(casted.Number, Is.EqualTo(0));
                Assert.That(casted.ToString(), Is.EqualTo("2018年6月第1木曜日"));
            }
            [Test()]
            public void Create_Case06_yyyymm_fr()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("2018/06/fr");
                var casted = pd as SdParamData.DayOfWeekSdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("2018/06/fr"));
                Assert.That(casted.Year, Is.EqualTo(2018));
                Assert.That(casted.Month, Is.EqualTo(6));
                Assert.That(casted.DayOfWeek, Is.EqualTo(DayOfWeek.Friday));
                Assert.That(casted.Relative, Is.False);
                Assert.That(casted.Number, Is.EqualTo(0));
                Assert.That(casted.ToString(), Is.EqualTo("2018年6月第1金曜日"));
            }
            [Test()]
            public void Create_Case07_yyyymm_sa()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("2018/06/sa");
                var casted = pd as SdParamData.DayOfWeekSdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("2018/06/sa"));
                Assert.That(casted.Year, Is.EqualTo(2018));
                Assert.That(casted.Month, Is.EqualTo(6));
                Assert.That(casted.DayOfWeek, Is.EqualTo(DayOfWeek.Saturday));
                Assert.That(casted.Relative, Is.False);
                Assert.That(casted.Number, Is.EqualTo(0));
                Assert.That(casted.ToString(), Is.EqualTo("2018年6月第1土曜日"));
            }


            [Test()]
            public void Create_Case11_mm_su()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("06/su");
                var casted = pd as SdParamData.DayOfWeekSdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("06/su"));
                Assert.That(casted.Year, Is.EqualTo(0));
                Assert.That(casted.Month, Is.EqualTo(6));
                Assert.That(casted.DayOfWeek, Is.EqualTo(DayOfWeek.Sunday));
                Assert.That(casted.Relative, Is.False);
                Assert.That(casted.Number, Is.EqualTo(0));
                Assert.That(casted.ToString(), Is.EqualTo("6月第1日曜日"));
            }
            [Test()]
            public void Create_Case12_mo()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("mo");
                var casted = pd as SdParamData.DayOfWeekSdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("mo"));
                Assert.That(casted.Year, Is.EqualTo(0));
                Assert.That(casted.Month, Is.EqualTo(0));
                Assert.That(casted.DayOfWeek, Is.EqualTo(DayOfWeek.Monday));
                Assert.That(casted.Relative, Is.False);
                Assert.That(casted.Number, Is.EqualTo(0));
                Assert.That(casted.ToString(), Is.EqualTo("実行登録日直近の月曜日"));
            }


            [Test()]
            public void Create_Case21_plus_yyyymm_su()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("2018/06/+su");
                var casted = pd as SdParamData.DayOfWeekSdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("2018/06/+su"));
                Assert.That(casted.Year, Is.EqualTo(2018));
                Assert.That(casted.Month, Is.EqualTo(6));
                Assert.That(casted.DayOfWeek, Is.EqualTo(DayOfWeek.Sunday));
                Assert.That(casted.Relative, Is.True);
                Assert.That(casted.Number, Is.EqualTo(0));
                Assert.That(casted.ToString(), Is.EqualTo("2018年6月相対日の第1日曜日"));
            }
            [Test()]
            public void Create_Case22_plus_yyyymm_mo()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("2018/06/+mo");
                var casted = pd as SdParamData.DayOfWeekSdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("2018/06/+mo"));
                Assert.That(casted.Year, Is.EqualTo(2018));
                Assert.That(casted.Month, Is.EqualTo(6));
                Assert.That(casted.DayOfWeek, Is.EqualTo(DayOfWeek.Monday));
                Assert.That(casted.Relative, Is.True);
                Assert.That(casted.Number, Is.EqualTo(0));
                Assert.That(casted.ToString(), Is.EqualTo("2018年6月相対日の第1月曜日"));
            }

            [Test()]
            public void Create_Case31_yyyymm_su_colon1()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("2018/06/su:1");
                var casted = pd as SdParamData.DayOfWeekSdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("2018/06/su:1"));
                Assert.That(casted.Year, Is.EqualTo(2018));
                Assert.That(casted.Month, Is.EqualTo(6));
                Assert.That(casted.DayOfWeek, Is.EqualTo(DayOfWeek.Sunday));
                Assert.That(casted.Relative, Is.False);
                Assert.That(casted.Number, Is.EqualTo(1));
                Assert.That(casted.ToString(), Is.EqualTo("2018年6月第1日曜日"));
            }
            [Test()]
            public void Create_Case32_yyyymm_su_colon2()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("2018/06/su:2");
                var casted = pd as SdParamData.DayOfWeekSdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("2018/06/su:2"));
                Assert.That(casted.Year, Is.EqualTo(2018));
                Assert.That(casted.Month, Is.EqualTo(6));
                Assert.That(casted.DayOfWeek, Is.EqualTo(DayOfWeek.Sunday));
                Assert.That(casted.Relative, Is.False);
                Assert.That(casted.Number, Is.EqualTo(2));
                Assert.That(casted.ToString(), Is.EqualTo("2018年6月第2日曜日"));
            }
            [Test()]
            public void Create_Case33_yyyymm_su_colonb()
            {
                // Arrange
                // Act
                var pd = SdParamData.Create("2018/06/su:b");
                var casted = pd as SdParamData.DayOfWeekSdParamData;

                // Assert
                Assert.That(casted.RawData, Is.EqualTo("2018/06/su:b"));
                Assert.That(casted.Year, Is.EqualTo(2018));
                Assert.That(casted.Month, Is.EqualTo(6));
                Assert.That(casted.DayOfWeek, Is.EqualTo(DayOfWeek.Sunday));
                Assert.That(casted.Relative, Is.False);
                Assert.That(casted.Number, Is.EqualTo(-1));
                Assert.That(casted.ToString(), Is.EqualTo("2018年6月最終の日曜日"));
            }
        }
    }
}
