using NUnit.Framework;
using Unclazz.Jp1ajs2.Schdls.Model;

namespace Test.Unclazz.Jp1ajs2.Schdls.Model
{
    [TestFixture()]
    public class WtParamDataTest
    {
        [Test()]
        public void Default_Case01_no()
        {
            // Arrange
            // Act
            var pd = WtParamData.Default;

            // Assert
            Assert.That(pd.RawData, Is.EqualTo("no"));
            Assert.That(pd.Unlimited, Is.False);
            Assert.That(pd.NoWait, Is.True);
            Assert.That(pd.Hour, Is.EqualTo(0));
            Assert.That(pd.Minute, Is.EqualTo(0));
            Assert.That(pd.Relative, Is.False);
            Assert.That(pd.ToString(), Is.EqualTo("起動条件なし"));
        }
        [Test()]
        public void Create_Case01_un()
        {
            // Arrange
            // Act
            var pd = WtParamData.Create("un");

            // Assert
            Assert.That(pd.RawData, Is.EqualTo("un"));
            Assert.That(pd.Unlimited, Is.True);
            Assert.That(pd.NoWait, Is.False);
            Assert.That(pd.Hour, Is.EqualTo(0));
            Assert.That(pd.Minute, Is.EqualTo(0));
            Assert.That(pd.Relative, Is.False);
            Assert.That(pd.ToString(), Is.EqualTo("無制限"));
        }
        [Test()]
        public void Create_Case11_no()
        {
            // Arrange
            // Act
            var pd = WtParamData.Create("no");

            // Assert
            Assert.That(pd.RawData, Is.EqualTo("no"));
            Assert.That(pd.Unlimited, Is.False);
            Assert.That(pd.NoWait, Is.True);
            Assert.That(pd.Hour, Is.EqualTo(0));
            Assert.That(pd.Minute, Is.EqualTo(0));
            Assert.That(pd.Relative, Is.False);
            Assert.That(pd.ToString(), Is.EqualTo("起動条件なし"));
        }
        [Test()]
        public void Create_Case21_nnnn()
        {
            // Arrange
            // Act
            var pd = WtParamData.Create("30");

            // Assert
            Assert.That(pd.RawData, Is.EqualTo("30"));
            Assert.That(pd.Unlimited, Is.False);
            Assert.That(pd.NoWait, Is.False);
            Assert.That(pd.Hour, Is.EqualTo(0));
            Assert.That(pd.Minute, Is.EqualTo(30));
            Assert.That(pd.Relative, Is.True);
            Assert.That(pd.ToString(), Is.EqualTo("相対時刻0時30分まで"));
        }
        [Test()]
        public void Create_Case22_nnnn()
        {
            // Arrange
            // Act
            var pd = WtParamData.Create("90");

            // Assert
            Assert.That(pd.RawData, Is.EqualTo("90"));
            Assert.That(pd.Unlimited, Is.False);
            Assert.That(pd.NoWait, Is.False);
            Assert.That(pd.Hour, Is.EqualTo(1));
            Assert.That(pd.Minute, Is.EqualTo(30));
            Assert.That(pd.Relative, Is.True);
            Assert.That(pd.ToString(), Is.EqualTo("相対時刻1時30分まで"));
        }
        [Test()]
        public void Create_Case23_nnnn()
        {
            // Arrange
            // Act
            var pd = WtParamData.Create("135");

            // Assert
            Assert.That(pd.RawData, Is.EqualTo("135"));
            Assert.That(pd.Unlimited, Is.False);
            Assert.That(pd.NoWait, Is.False);
            Assert.That(pd.Hour, Is.EqualTo(2));
            Assert.That(pd.Minute, Is.EqualTo(15));
            Assert.That(pd.Relative, Is.True);
            Assert.That(pd.ToString(), Is.EqualTo("相対時刻2時15分まで"));
        }
        [Test()]
        public void Create_Case31_hhmm()
        {
            // Arrange
            // Act
            var pd = WtParamData.Create("00:30");

            // Assert
            Assert.That(pd.RawData, Is.EqualTo("00:30"));
            Assert.That(pd.Unlimited, Is.False);
            Assert.That(pd.NoWait, Is.False);
            Assert.That(pd.Hour, Is.EqualTo(0));
            Assert.That(pd.Minute, Is.EqualTo(30));
            Assert.That(pd.Relative, Is.False);
            Assert.That(pd.ToString(), Is.EqualTo("絶対時刻0時30分まで"));
        }
        [Test()]
        public void Create_Case32_hhmm()
        {
            // Arrange
            // Act
            var pd = WtParamData.Create("01:30");

            // Assert
            Assert.That(pd.RawData, Is.EqualTo("01:30"));
            Assert.That(pd.Unlimited, Is.False);
            Assert.That(pd.NoWait, Is.False);
            Assert.That(pd.Hour, Is.EqualTo(1));
            Assert.That(pd.Minute, Is.EqualTo(30));
            Assert.That(pd.Relative, Is.False);
            Assert.That(pd.ToString(), Is.EqualTo("絶対時刻1時30分まで"));
        }
        [Test()]
        public void Create_Case33_hhmm()
        {
            // Arrange
            // Act
            var pd = WtParamData.Create("02:15");

            // Assert
            Assert.That(pd.RawData, Is.EqualTo("02:15"));
            Assert.That(pd.Unlimited, Is.False);
            Assert.That(pd.NoWait, Is.False);
            Assert.That(pd.Hour, Is.EqualTo(2));
            Assert.That(pd.Minute, Is.EqualTo(15));
            Assert.That(pd.Relative, Is.False);
            Assert.That(pd.ToString(), Is.EqualTo("絶対時刻2時15分まで"));
        }
        [Test()]
        public void Create_Case34_hhmm()
        {
            // Arrange
            // Act
            var pd = WtParamData.Create("0:05");

            // Assert
            Assert.That(pd.RawData, Is.EqualTo("0:05"));
            Assert.That(pd.Unlimited, Is.False);
            Assert.That(pd.NoWait, Is.False);
            Assert.That(pd.Hour, Is.EqualTo(0));
            Assert.That(pd.Minute, Is.EqualTo(5));
            Assert.That(pd.Relative, Is.False);
            Assert.That(pd.ToString(), Is.EqualTo("絶対時刻0時5分まで"));
        }

    }
}
