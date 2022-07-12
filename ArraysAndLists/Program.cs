using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<int>  evens = new List<int>();
            List<int> odds = new List<int>();

            for (int i = 0; i <= myArray.Length; i++)
            {
                if (i % 2 == 0)
                {
                    evens.Add(i);
                }

                else
                {
                    odds.Add(i);
                }
            }

            Console.WriteLine("Evens List");

            foreach (var number in evens)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine(" ");
            Console.WriteLine("Odds List");

            foreach (var number in odds)
            {
                Console.WriteLine(number);
            }


            
        }

        
    }
}
