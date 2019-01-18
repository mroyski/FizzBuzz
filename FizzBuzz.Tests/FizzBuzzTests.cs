using System;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void Get_Returns_1_For_1()
        {
            // Arrange
            var FizzBuzz = new FizzBuzz();

            // Act
            var result = FizzBuzz.Get(1);

            // Assert
            Assert.Equal("1", result);
        }

        [Fact]
        public void Get_Returns_2_for_2()
        {
            var FizzBuzz = new FizzBuzz();

            var result = FizzBuzz.Get(2);

            Assert.Equal("2", result);
        }

        [Fact]
        public void Get_Returns_Fizz_for_3()
        {
            var FizzBuzz = new FizzBuzz();

            var result = FizzBuzz.Get(3);

            Assert.Equal("Fizz", result);
        }
        [Fact]
        public void Get_Returns_Fizz_for_6()
        {
            var FizzBuzz = new FizzBuzz();

            var result = FizzBuzz.Get(6);

            Assert.Equal("Fizz", result);
        }
        [Fact]
        public void Get_Returns_Buzz_for_5()
        {
            var FizzBuzz = new FizzBuzz();

            var result = FizzBuzz.Get(5);

            Assert.Equal("Buzz", result);
        }
        [Fact]
        public void Get_Returns_Buzz_for_10()
        {
            var FizzBuzz = new FizzBuzz();

            var result = FizzBuzz.Get(10);

            Assert.Equal("Buzz", result);
        }
    }
}
