using KataFizzBuzz;
using NUnit.Framework;
using Moq;
using System.Collections.Generic;
using System;

namespace TestProjectFizzBuzz
{
    public class Tests
    {
        IFizzBuzzCounter _sut;
        Mock<IReader> _readerMock;

        [SetUp]
        public void Setup()
        {
            _readerMock = new Mock<IReader>();
            _sut = new FizzBuzzCounter(_readerMock.Object);
        }

        [TestCase(1, ExpectedResult = "1")]
        [TestCase(2, ExpectedResult = "2")]
        [TestCase(3, ExpectedResult = "Fizz")]
        [TestCase(4, ExpectedResult = "4")]
        [TestCase(5, ExpectedResult = "Buzz")]
        [TestCase(15, ExpectedResult = "FizzBuzz")]
        public string TestFizzBuzz(int input) => _sut.Translate(input);

        [Test]
        public void TestFizzBuzzCounter()
        {
            var expected = new List<string> { "1", "2", "Fizz" }; //continuous until your input number... o try to make a new test
            var actual = _sut.Counter(3);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestFizzBuzzCounter2()
        {
            var expected = new List<string> { "1", "2", "Fizz", "4", "Buzz", "Fizz" }; //continuous until your input number... o try to make a new test
            var actual = _sut.Counter(6);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestFizzBuzzCounter_ZeroElements()
        {
            var expected = new List<string> ();
            var actual = _sut.Counter(0);
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void TestFizzBuzzCounter_NegativeElements_ThrowsException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => { _sut.Counter(-5); });
        }

        [Test]
        public void TestFizzBuzzCounterFromReader()
        {
            _readerMock.Setup(x => x.Read()).Returns(7);

            var actual = _sut.CounterFromReader();

            var expected = new List<string> { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7" };
            Assert.AreEqual(expected, actual);
        }
    }
}
