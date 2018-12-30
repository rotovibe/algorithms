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
    public class MergeSortArrayTest
    {
        [Test]
        public void BothArraysAreEmptyTest()
        {
            var myArray = new int[] { };
            var alicesArray = new int[] { };
            var expected = new int[] { };
            var actual = MergeSort.MergeArrays(myArray, alicesArray);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FirstArrayIsEmptyTest()
        {
            var myArray = new int[] { };
            var alicesArray = new int[] { 1, 2, 3 };
            var expected = new int[] { 1, 2, 3 };
            var actual = MergeSort.MergeArrays(myArray, alicesArray);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SecondArrayIsEmptyTest()
        {
            var myArray = new int[] { 5, 6, 7 };
            var alicesArray = new int[] { };
            var expected = new int[] { 5, 6, 7 };
            var actual = MergeSort.MergeArrays(myArray, alicesArray);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BothArraysHaveSomeNumbersTest()
        {
            var myArray = new int[] { 2, 4, 6 };
            var alicesArray = new int[] { 1, 3, 7 };
            var expected = new int[] { 1, 2, 3, 4, 6, 7 };
            var actual = MergeSort.MergeArrays(myArray, alicesArray);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ArraysAreDifferentLengthsTest()
        {
            var myArray = new int[] { 2, 4, 6, 8 };
            var alicesArray = new int[] { 1, 7 };
            var expected = new int[] { 1, 2, 4, 6, 7, 8 };
            var actual = MergeSort.MergeArrays(myArray, alicesArray);
            Assert.AreEqual(expected, actual);
        }
    }
}
