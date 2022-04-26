using System;

namespace OOP.Exercises
{
    public class Stopwatch
    {
        public DateTime StartTime { get; private set; }

        public Stopwatch()
        {
            ZeroTimer();
        }

        public void Start()
        {
            if (StartTime != DateTime.MinValue) throw new InvalidOperationException();
            StartTime = DateTime.Now;
        }

        public void Stop()
        {
            if (StartTime == DateTime.MinValue) throw new InvalidOperationException();

            var timeSpan = DateTime.Now - StartTime;

            ZeroTimer();

            Console.WriteLine("\nTime passed:" + timeSpan);
        }

        public void ZeroTimer()
        {
            StartTime = DateTime.MinValue;
        }

        //public static void Stopwatch()
        //{
        //    var stopwatch = new Stopwatch();

        //    Console.WriteLine("Press <1> to start a stop watch");
        //    var userInput = Console.ReadKey().Key;

        //    while (userInput != ConsoleKey.Escape)
        //    {
        //        switch (userInput)
        //        {
        //            case ConsoleKey.D1:
        //                stopwatch.Start();
        //                Console.WriteLine("\nTo stop stopwatch press <Enter>");
        //                break;
        //            case ConsoleKey.Enter:
        //                stopwatch.Stop();
        //                Console.WriteLine("\nTo exit the program press <Escape>\n");
        //                break;
        //            default:
        //                Console.WriteLine("\nInvalid Operation");
        //                break;
        //        }

        //        userInput = Console.ReadKey().Key;

        //    }
    }
}