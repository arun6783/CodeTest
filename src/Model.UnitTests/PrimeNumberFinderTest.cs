using NUnit.Framework;

namespace Model.UnitTests
{
    public class PrimeNumberFinderTest
    {
        [Test]
        public void  ShouldReturnTrueIfNumberGivenIsPrimeNumber()
        {
            bool isNumberPrime = PrimeNumberFinder.IsNumberPrime(2);

            Assert.IsTrue(isNumberPrime);
        }
        
        [Test]
        public void  ShouldReturnFalseIfNumberGivenIsNotAPrimeNumber()
        {
            bool isNumberPrime = PrimeNumberFinder.IsNumberPrime(4);

            Assert.False(isNumberPrime);
        }
    }
}