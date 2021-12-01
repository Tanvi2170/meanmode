using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meanmode
{
     
    internal class Program
    {

        static int[] data = { 40, 38, 37, 36, 34, 33, 32, 31, 30, 30, 30, 29, 26, 26, 19 };

        static void Main(string[] args)
        {

            var sobject = new stats();
            sobject.numbers = data;
            var Sum = sobject.calculatesum();
            Console.WriteLine($"Sum:{Sum}");


            var mean = sobject.calculatemean();
            Console.WriteLine($"Mean:{mean}");

            var median = sobject.calculatemedian();
            Console.WriteLine($"Median:{median}");


            var mode = sobject.calculatemode();
            Console.WriteLine($"Mode:{mode}");
            Console.ReadLine();
        }
    }
}
