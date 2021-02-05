using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace FizBuzz.UnitTests
{
    [TestFixture]
    public class FizzBuzzTest
    {
        [Test]
        public void FizzBuzzer_Given1_returnsString1()
        {
            //Arrange 
            var sut = new FizzBuzz.FizzBuzz();
            var result = sut.FizzBuzzer(1);
            Assert.AreEqual("1", result);

        }
        [Test]
        public void FizzBuzzer_Given2_returnsString1()
        {
            //Arrange 
            var sut = new FizzBuzz.FizzBuzz();
            var result = sut.FizzBuzzer(2);
            Assert.AreEqual("2", result);

        }
        [Test]
        public void FizzBuzzer_Given3_returnsFizz1()
        {
            //Arrange 
            var sut = new FizzBuzz.FizzBuzz();
            var result = sut.FizzBuzzer(3);
            Assert.AreEqual("Fizz", result);

        }
        [Test]
        public void FizzBuzzer_Given6_returnsFizz1()
        {
            //Arrange 
            var sut = new FizzBuzz.FizzBuzz();
            var result = sut.FizzBuzzer(6);
            Assert.AreEqual("Fizz", result);

        }
        [Test]
        public void FizzBuzzer_Given5_returnsBuzz1()
        {
            //Arrange 
            var sut = new FizzBuzz.FizzBuzz();
            var result = sut.FizzBuzzer(5);
            Assert.AreEqual("Buzz", result);

        }
        [Test]
        public void FizzBuzzer_Given15_returnsFizzBuzz1()
        {
            //Arrange 
            var sut = new FizzBuzz.FizzBuzz();
            var result = sut.FizzBuzzer(15);
            Assert.AreEqual("FizzBuzz", result);

        }
    }
}