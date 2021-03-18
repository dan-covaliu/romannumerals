using System;
using NFluent;
using NUnit.Framework;
using RomanNumerals;

namespace RomanNumeralsTest
{
    [TestFixture]
    public class RomanNumeralsConverterTests
    {
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
        public void TestOne(string expected, int actual)
        {
            RomanNumeralsConverter romanNumeralsConverter = new RomanNumeralsConverter();
            string actualString = romanNumeralsConverter.Convert(actual);
            //Assert.AreEqual(expected, actualString);
            Check.That(actualString).IsEqualTo(expected);
        }
    }
}