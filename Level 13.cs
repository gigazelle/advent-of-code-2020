using System;
using System.Collections.Generic;
using System.Linq;

namespace Advent_of_Code
{
    class Level_13
    {

        static void Main(string[] args)
        {
            // Get the busID list and correct modulo list "1789,37,47,1889";//
            string busRaw = "23,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,37,x,x,x,x,x,431,x,x,x,x,x,x,x,x,x,x,x,x,13,17,x,x,x,x,19,x,x,x,x,x,x,x,x,x,x,x,409,x,x,x,x,x,x,x,x,x,41,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,29";
            string[] busArray = busRaw.Split(",");
            List<int> correctModulo = new List<int>();
            List<int> busIDs = new List<int>();
            for (int a = 0; a < busArray.Length; a++)
            {
                if (busArray[a] != "x")
                {
                    busIDs.Add(Int32.Parse(busArray[a]));
                    int modulo = a;
                    while(modulo > busIDs.Last()) modulo -= busIDs.Last();
                    correctModulo.Add(modulo);
                    Console.WriteLine("Bus ID: " + busIDs.Last() + " Modulo: " + correctModulo.Last());
                }
            }

            long timestamp = 0;
            // Start by skipping in increments of the first bus ID
            long advanceBy = busIDs[0];
            // Each iteration in this for loop is a busID. It repeats inside the for loop until the desired modulo is achieved.
            for (int i = 1; i < busIDs.Count; i++)
            {
                while (true)
                {
                    // Repeat this until you get one of the modulos correct

                    if (Convert.ToInt32(busIDs[i] - timestamp % busIDs[i]) == correctModulo[i])
                    {
                        // If it's the desired modulo, move on to the next bus and multiply time advancement
                        Console.WriteLine("Timestamp: " + timestamp + " Bus: " + busIDs[i]);
                        advanceBy *= busIDs[i];
                        Console.WriteLine("Now advancing by " + advanceBy);
                        break;
                    }
                    else
                    {
                        //Console.WriteLine("Modulo: " + (busIDs[i] - timestamp % busIDs[i]) + " Timestamp: " + timestamp);

                        // Otherwise just advance time
                        timestamp += advanceBy;
                    }
                }
            }
            Console.WriteLine(timestamp);
        }
    }
}
