using System;
using System.Collections.Generic;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject sub1 = new Subject("S01", "Code C#", 3);

            Mark m1 = new Mark("SV001", "S01", 8.5);

            Console.WriteLine("--- Subject ìno ---");
            sub1.DisplaySubject();

            Console.WriteLine("\n--- Grade ìno ---");
            m1.DisplayMark();

            Console.ReadLine();
        }
    }
}
