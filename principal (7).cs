using System;
using System.Collections.Generic;

class Program
{
    public class Event
    {
        public int x;
        public int y1;
        public int y2;
        public bool isStart;

        public Event(int x, int y1, int y2, bool isStart)
        {
            this.x = x;
            this.y1 = y1;
            this.y2 = y2;
            this.isStart = isStart;
        }
    }

    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        List<Event> events = new List<Event>();

        for (int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split();
            int xi = int.Parse(input[0]);
            int xf = int.Parse(input[1]);
            int yi = int.Parse(input[2]);
            int yf = int.Parse(input[3]);

            events.Add(new Event(xi, yi, yf, true));
            events.Add(new Event(xf, yi, yf, false));
        }

        events.Sort((a, b) => a.x != b.x ? a.x - b.x : (a.isStart ? -1 : 1));

        int lastX = events[0].x;
        int totalArea = 0;
        SortedSet<int> activeY = new SortedSet<int>();

        foreach (var e in events)
        {
            int currentX = e.x;

            if (activeY.Count > 0)
            {
                int lastY = -1;
                int coveredLength = 0;

                foreach (var y in activeY)
                {
                    if (lastY != -1)
                    {
                        coveredLength += y - lastY;
                    }
                    lastY = y;
                }

                totalArea += coveredLength * (currentX - lastX);
            }

            if (e.isStart)
            {
                activeY.Add(e.y1);
                activeY.Add(e.y2);
            }
            else
            {
                activeY.Remove(e.y1);
                activeY.Remove(e.y2);
            }

            lastX = currentX;
        }

        Console.WriteLine(totalArea);
    }
}
