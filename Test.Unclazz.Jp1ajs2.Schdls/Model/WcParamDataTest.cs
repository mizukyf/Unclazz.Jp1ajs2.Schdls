using NUnit.Framework;
using System;
using Unclazz.Jp1ajs2.Schdls.Model;

namespace Test.Unclazz.Jp1ajs2.Schdls.Model
{
    [TestFixture()]
    public class WcParamDataTest
    {
        [Test()]
        public void Default_Case01_no()
        {
            // Arrange
            // Act
            var pd = WcParamData.Default;

            // Assert
            Assert.That(pd.RawData, Is.EqualTo("no"));
            Assert.That(pd.Unlimited, Is.False);
            Assert.That(pd.NoWait, Is.True);
            Assert.That(pd.Count, Is.EqualTo(0));
            Assert.That(pd.ToString(), Is.EqualTo("起動条件なし"));
        }
        [Test()]
        public void Create_Case01_un()
        {
            // Arrange
            // Act
            var pd = WcParamData.Create("un");

            // Assert
            Assert.That(pd.RawData, Is.EqualTo("un"));
            Assert.That(pd.Unlimited, Is.True);
            Assert.That(pd.NoWait, Is.False);
            Assert.That(pd.Count, Is.EqualTo(0));
            Assert.That(pd.ToString(), Is.EqualTo("無制限"));
        }
        [Test()]
        public void Create_Case11_no()
        {
            // Arrange
            // Act
            var pd = WcParamData.Create("no");

            // Assert
            Assert.That(pd.RawData, Is.EqualTo("no"));
            Assert.That(pd.Unlimited, Is.False);
            Assert.That(pd.NoWait, Is.True);
            Assert.That(pd.Count, Is.EqualTo(0));
            Assert.That(pd.ToString(), Is.EqualTo("起動条件なし"));
        }
        [Test()]
        public void Create_Case21_n()
        {
            // Arrange
            // Act
            var pd = WcParamData.Create("1");

            // Assert
            Assert.That(pd.RawData, Is.EqualTo("1"));
            Assert.That(pd.Unlimited, Is.False);
            Assert.That(pd.NoWait, Is.False);
            Assert.That(pd.Count, Is.EqualTo(1));
            Assert.That(pd.ToString(), Is.EqualTo("1回まで"));
        }
        [Test()]
        public void Create_Case22_nn()
        {
            // Arrange
            // Act
            var pd = WcParamData.Create("10");

            // Assert
            Assert.That(pd.RawData, Is.EqualTo("10"));
            Assert.That(pd.Unlimited, Is.False);
            Assert.That(pd.NoWait, Is.False);
            Assert.That(pd.Count, Is.EqualTo(10));
            Assert.That(pd.ToString(), Is.EqualTo("10回まで"));
        }
    }
}
