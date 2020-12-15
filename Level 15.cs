using System;
using System.Collections.Generic;
using System.Linq;

namespace Advent_of_Code
{
    class Level_15
    {

        static void Main(string[] args)
        {
            int[] initialNumbers = { 14, 3, 1, 0, 9, 5 };
            List<int> sequence = new List<int>();
            foreach (int n in initialNumbers) sequence.Add(n);
            for (int i = 6; i < 30000000+1; i++)
            {
                // grab the last number
                int lastNumber = sequence[i - 1];
                // remove it so we're not checking it
                sequence.RemoveAt(sequence.Count-1);

                if (!sequence.Contains(lastNumber))
                {
                    //Console.WriteLine(lastNumber + " not found. Number is 0.");
                    // add last number back
                    sequence.Add(lastNumber);
                    // then add the extra number.
                    sequence.Add(0);
                }
                else
                {
                    int store = i-sequence.LastIndexOf(lastNumber)-1;
                    //Console.WriteLine(lastNumber + " found at index " + sequence.LastIndexOf(lastNumber) + ". Number is " + store + ".");
                     // add last number back
                    sequence.Add(lastNumber);                   
                    // then add the extra number.
                    sequence.Add(store );
                }
                //Console.WriteLine(sequence[i]);

            }
            Console.WriteLine(sequence[30000000-1]);
        }
    }
}