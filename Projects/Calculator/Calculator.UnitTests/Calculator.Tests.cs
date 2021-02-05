using System;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Calculator.UnitTests
{
    [TestFixture]
    public class CalculatorTest
    {
        public Calculator sut;

        [SetUp]
        public void Setup()
        {
            sut = new Calculator();
        }

        [TearDown]
        public void TearDown()
        {
          //  sut.D
        }

        [Test]
        public void Addition_Provide3and5_returns8()
        {
            //Arrange
            

            //Act
            var result = sut.Addition(3, 5);
            //Assert

            Assert.AreEqual(8, result);
        }

        [Test]
        public void Addition_Provide5and5_returns10()
        {
            //Arrange


            //Act
            var result = sut.Addition(5, 5);
            //Assert

            Assert.AreEqual(10, result);
        }

        [TestCase(1,4,5)]
        [TestCase(6, 4, 10)]
        public void Addition_ProvidingVariousNumbers_returnsCorrectResult(int first, int second, int expectedResult)
        {
            //Arrange

            //Act
            var result = sut.Addition(first, second);
            //Assert

            Assert.AreEqual(expectedResult, result);
        }
        [Test, Order(2)]
        public void Subtraction_Given5and2_returns3()
        {
            //Arrange
            

            //Act
            var result = sut.Subtraction(5,2);
            //Assert

            Assert.AreEqual(3, result);
        }

        [Ignore("temporarily ignored")]
        public void Subtraction_Given3and5_returnsError()
        {
            //Arrange
           

            //Act & Assert
            
            Assert.Catch<ArgumentException>(() => sut.Subtraction(3, 5));
         
        }


    }
}
