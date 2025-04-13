using Examples;

namespace UnitTests
{
    public class FizzBuzzTests
    {
        FizzBuzz FizzBuzz = new();
        [Fact]
        public void FizzForMultiplesOfThree()
        {
            var result = FizzBuzz.GetOutput(3);
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void BuzzForMultiplesOfFive()
        {
            var result = FizzBuzz.GetOutput(20);
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void FizzBuzzForMultiplesOfThreeAndFive()
        {
            var result = FizzBuzz.GetOutput(15);
            Assert.Equal("FizzBuzz", result);
        }
    }
}
