using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingMaximumNumberInList
{
    internal class Program
    {
        /*
        Question 3: Finding the Maximum Value
        in a List
        Create a list of integers with at least
        ten random values.
        Find and print the maximum value in the list.
        */
        static void Main(string[] args)
        {
            List<int> randomIntegers = new List<int>
         {
             2,4,6,1,3,5,8,10,12,7,9,11
         };

            int maximumValue = randomIntegers[0];

            for (int x = 0; x < randomIntegers.Count; x++)
            {
                if (randomIntegers[x] > maximumValue)
                {
                    maximumValue = randomIntegers[x];
                }
            }
            Console.WriteLine($"Maximum value: {maximumValue}");
        }
    }
}
