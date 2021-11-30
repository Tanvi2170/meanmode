using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meanmode
{
    internal class mean
    { public static void showoutput()
        {
            int[] numbers = { 40, 38, 37, 36, 34, 33, 32, 31, 30, 30, 30, 29, 26, 26, 19 };
            int sum = 0;
            double means = 0;
            decimal median = 0;
            int numbercount = numbers.Count();
            int halfindex = numbers.Count() / 2;
         
           
            var sortedNumbers = numbers.OrderBy(n => n);
            foreach (int items in numbers)
            {
                sum += items;
            }
            Console.WriteLine("total array count  = " + numbercount);
            Console.WriteLine("sum of the array numbers is = " + sum);

            // mean
            {
                means = sum / numbercount;
            }
            Console.WriteLine("Mean of the array numbers is = " + means);

            // median 
            {
                median = sortedNumbers.ElementAt(halfindex);
            }
            Console.WriteLine("median of the array numbers is = " + median);

            //mode
            
            {
               
                int max = numbers.Max();
                int n = numbers.Length;


                int t = max + 1;
                int[] count = new int[t];
                for (int i = 0; i < t; i++)
                    count[i] = 0;

                
                for (int i = 0; i < n; i++)
                    count[numbers[i]]++;

                // mode is the index with maximum count
                int mode = 0;
                int k = count[0];
                for (int i = 1; i < t; i++)
                {
                    if (count[i] > k)
                    {
                        k = count[i];
                        mode = i;
                    }
                }

                Console.WriteLine("mode = " + mode);
            }

        }


    }
}
