
using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static List<Meeting> MergeRanges(List<Meeting> meetings)
        {
            // make a sorted by start date copy
            var sortedMeetings = meetings.Select(m => new Meeting(m.StartTime, m.EndTime))
                .OrderBy(m => m.StartTime)
                .ToList();

            // initialize merged meetings with earliest entry
            var mergedMeetings = new List<Meeting> { sortedMeetings[0] };

            foreach (var currentMeeting in sortedMeetings)
            {
                // get last on merged list
                var lastMeeting = mergedMeetings.Last();

                if (currentMeeting.StartTime <= lastMeeting.EndTime)
                {
                    // if current meeting overlaps witht he last merged meeting, use the later end time of the two
                    lastMeeting.EndTime = Math.Max(currentMeeting.EndTime, lastMeeting.EndTime);
                }
                else
                {
                    mergedMeetings.Add(currentMeeting);
                }
            }

            return mergedMeetings;
        }
    }
}
