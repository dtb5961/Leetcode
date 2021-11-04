using System;
using UtilityLibraries;

namespace ShowCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Val1: ");
            int val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Val2: ");
            int val2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sum is " + UtilityLibraries.Math.sumAsString(val1, val2));
        }
    }
}
