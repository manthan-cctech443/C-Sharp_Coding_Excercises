using System;

namespace Coding.Exercise
{
    internal class Exercise
    {
        public struct Event
        {
            // TODO: Add your code here
            public DateTime StartDate;
            public DateTime EndDate;
            public double GetDuration()
            {
                TimeSpan duration = EndDate - StartDate;
                double duration1 = duration.TotalDays;
                return duration1;

            }
            public bool IsOverlapping(Event otherEvent)
            {
                return StartDate < otherEvent.EndDate && EndDate > otherEvent.StartDate;
            }
        }

        
        public static void TestEvents()
        {
            // TODO: Add your code here
            Event event1 = new Event();
            event1.StartDate = new DateTime(2024, 07, 01);
            event1.EndDate = new DateTime(2024, 07, 10);
            Event event2 = new Event();
            event2.StartDate = new DateTime(2024, 07, 05);
            event2.EndDate = new DateTime(2024, 07, 15);
            Console.WriteLine("Event 1 Duration: " + event1.GetDuration() + " days");
            Console.WriteLine("Event 2 Duration: " + event2.GetDuration() + " days");
            Console.WriteLine("Events Overlap: " + event1.IsOverlapping(event2));

        }
        
        public static void Main(string[] args)
        {
            TestEvents();
        }
    }
}