using System;
using NUnit.Framework;
using RomanNumerals;

namespace RomanNumeralsTest
{
    [TestFixture]
    public class RomanNumeralsConverterTests
    {
        private RomanNumeralsConverter _romanNumeralsConverter;

        [SetUp]
        public void Init()
        {
            _romanNumeralsConverter = new RomanNumeralsConverter();
        }

        [TestCase("I",  1)]
        [TestCase("II", 2)]
        [TestCase("V", 5)]
        [TestCase("L", 50)]
        [TestCase("LXVII", 67)]
        [TestCase("XCIX", 99)]
        [TestCase("CCCLX", 360)]
        [TestCase("MDCCCXC", 1890)]
        [TestCase("MMMCMXCIX", 3999)]
        [TestCase("MMMDLXXXVIII", 3588)]
        [TestCase("MMM", 3000)]
        [TestCase("MMCMXCIX", 2999)]
        public void TestUpToFourThousand(string expected, int actual)
        {
            string actualString = _romanNumeralsConverter.Convert(actual);
            Assert.AreEqual(expected, actualString);
        }

        [TestCase("MMMM", 4000)]
        [TestCase("MMMMI", 4001)]
        public void TestAtLeastFourThousand(string expected, int actual)
        {
            Assert.Throws<ArgumentException>(() => _romanNumeralsConverter.Convert(actual));
        }
    }
}