using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meanmode
{
    internal class stats
    {
        internal int[] numbers { private get; set; }

        /// <summary>
        /// method will calculate the sum of the encapsulated
        /// </summary>
        /// <returns>the sum of integers as an integer type</returns>
        /// 
        internal int calculatesum()
        {
            int sum = 0;

            foreach (int items in numbers)
            {
                sum += items;
            }
            // this uses a nifty util from .NET from the LINQ namespace
            // see the "using..." section at the top of the file

            return sum;
        }
        internal double calculatemean()
        {
            double means = 0;
            int numbercount = numbers.Count();
            int halfindex = numbers.Count() / 2;

            means = calculatesum() / numbercount;

            return means;
        }
        internal double calculatemedian()
        {
            double median = 0;
            int numbercount = numbers.Count();
            int halfindex = numbers.Count() / 2;

            var sortedNumbers = numbers.OrderBy(n => n);
            if ((numbercount % 2) == 0)
            {
                median = ((sortedNumbers.ElementAt(halfindex) + sortedNumbers.ElementAt((halfindex - 1))) / 2);
            }
            else
            {
                median = sortedNumbers.ElementAt(halfindex);

            }

            return median;
        }
        internal double calculatemode()
        // mode is the index with maximum count
        {
            double mode = 0;
            int max = numbers.Max();
            int n = numbers.Length;


            int t = max + 1;
            int[] count = new int[t];
            for (int i = 0; i < t; i++)
                count[i] = 0;


            for (int i = 0; i < n; i++)
                count[numbers[i]]++;


            int k = count[0];
            for (int i = 1; i < t; i++)
            {
                if (count[i] > k)
                {
                    k = count[i];
                    mode = i;
                }
            }

            return mode;
        }


    }
}
