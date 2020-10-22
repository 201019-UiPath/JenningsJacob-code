using System;
using Xunit;
using HerosLib;

namespace HerosTest
{
    public class HeroTest
    {
        Hero testHero = new Hero();

        [Theory]
        [InlineData("Unit testing god")]
        [InlineData("Flying")]
        [InlineData("Laser Eyes")]
        public void AddSuperPowerShouldAddSuperPower(string superPower)
        {
            // Act (Do the thing you want to test)
            testHero.AddSuperPower(superPower);

            // Assert
            Assert.Equal(superPower, Hero.superPowers.Peek());
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void AddSuperPowerShouldThrowArgumentException(string superPower)
        {
            Assert.Throws<ArgumentException>(() => testHero.AddSuperPower(superPower));
        }
    }
}
