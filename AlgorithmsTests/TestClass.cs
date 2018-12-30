﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm;
using Algorithm;

namespace AlgorithmsTests
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void MeetingsOverlapTest()
        {
            var meetings = new List<Meeting>()
        {
            new Meeting(1, 3), new Meeting(2, 4)
        };
            var actual = Program.MergeRanges(meetings);
            var expected = new List<Meeting>()
        {
            new Meeting(1, 4)
        };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MeetingsTouchTest()
        {
            var meetings = new List<Meeting>()
        {
            new Meeting(5, 6), new Meeting(6, 8)
        };
            var actual = Program.MergeRanges(meetings);
            var expected = new List<Meeting>()
        {
            new Meeting(5, 8)
        };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MeetingContainsOtherMeetingTest()
        {
            var meetings = new List<Meeting>()
        {
            new Meeting(1, 8), new Meeting(2, 5)
        };
            var actual = Program.MergeRanges(meetings);
            var expected = new List<Meeting>()
        {
            new Meeting(1, 8)
        };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MeetingsStaySeparateTest()
        {
            var meetings = new List<Meeting>()
        {
            new Meeting(1, 3), new Meeting(4, 8)
        };
            var actual = Program.MergeRanges(meetings);
            var expected = new List<Meeting>()
        {
            new Meeting(1, 3), new Meeting(4, 8)
        };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MultipleMergedMeetingsTest()
        {
            var meetings = new List<Meeting>()
        {
            new Meeting(1, 4), new Meeting(2, 5), new Meeting (5, 8)
        };
            var actual = Program.MergeRanges(meetings);
            var expected = new List<Meeting>()
        {
            new Meeting(1, 8)
        };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MeetingsNotSortedTest()
        {
            var meetings = new List<Meeting>()
        {
            new Meeting(5, 8), new Meeting(1, 4), new Meeting(6, 8)
        };
            var actual = Program.MergeRanges(meetings);
            var expected = new List<Meeting>()
        {
            new Meeting(1, 4), new Meeting(5, 8)
        };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void OneLongMeetingContainsSmallerMeetingsTest()
        {
            var meetings = new List<Meeting>()
        {
            new Meeting(1, 10), new Meeting(2, 5), new Meeting(6, 8),
            new Meeting(9, 10), new Meeting(10, 12)
        };
            var actual = Program.MergeRanges(meetings);
            var expected = new List<Meeting>()
        {
            new Meeting(1, 12)
        };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SampleInputTest()
        {
            var meetings = new List<Meeting>()
        {
            new Meeting(0, 1), new Meeting(3, 5), new Meeting(4, 8),
            new Meeting(10, 12), new Meeting(9, 10)
        };
            var actual = Program.MergeRanges(meetings);
            var expected = new List<Meeting>()
        {
            new Meeting(0, 1), new Meeting(3, 8), new Meeting(9, 12)
        };
            Assert.AreEqual(expected, actual);
        }
    }
}
