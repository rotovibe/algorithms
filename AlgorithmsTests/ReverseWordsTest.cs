using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm;

namespace AlgorithmsTests
{
    [TestFixture]
    public class ReverseWordsTest
    {
        [Test]
        public void OneWordTest()
        {
            var expected = "vault".ToCharArray();
            var actual = "vault".ToCharArray();
            ReverseWords.ReverseAllWords(actual);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TwoWordsTest()
        {
            var expected = "cake thief".ToCharArray();
            var actual = "thief cake".ToCharArray();
            ReverseWords.ReverseAllWords(actual);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ThreeWordsTest()
        {
            var expected = "get another one".ToCharArray();
            var actual = "one another get".ToCharArray();
            ReverseWords.ReverseAllWords(actual);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MultipleWordsSameLengthTest()
        {
            var expected = "the cat ate the rat".ToCharArray();
            var actual = "rat the ate cat the".ToCharArray();
            ReverseWords.ReverseAllWords(actual);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MultipleWordsDifferentLengthsTest()
        {
            var expected = "chocolate bundt cake is yummy".ToCharArray();
            var actual = "yummy is cake bundt chocolate".ToCharArray();
            ReverseWords.ReverseAllWords(actual);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void EmptyStringTest()
        {
            var expected = "".ToCharArray();
            var actual = "".ToCharArray();
            ReverseWords.ReverseAllWords(actual);
            Assert.AreEqual(expected, actual);
        }
    }
}
