using System;
using System.Linq;

namespace ExtensionMethods.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //var items = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var items = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            //var evenNumbers = items.Where(x => x % 2 == 0);
            var evenNumbers = items.Filter(x=>x>7).Select(x => $"Item Number: {x}");
            Console.WriteLine($"Even Number: {string.Join(',', evenNumbers)}");
            Console.ReadKey();
        }
    }
}
