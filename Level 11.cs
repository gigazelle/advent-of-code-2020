using System;
using System.Collections.Generic;
using System.Linq;

namespace Advent_of_Code
{
    class Level_11
    {
        static void Main_11(string[] args)
        {
            string[] seats = {"LLLLLLLLL.LLLLL.LLLLL.LLLL.LLLLLL.LL.LLLLLLLLLLLLL.LLLLLL.LLLLLLLLLLLLLLL.LLLL.LLLL.LLLL.LLLLL",
"LLLLLLLLL.LLLLL.LLLLL.LLLLLLLL.LLLLL.LLLLLLLLLLLLL.LLLLLLLLLLLLLLLLLL.LLL.LLLL.LLLLLLLLLLLLLLL",
"LLLLLLLLL.LLLLL.LLLLL.LLLLLLLLLLLLL..LLLLLLL..LLLLLLLLLLLLLLLLLLLLLLLLLLL.LLLL.LLLL.LLLLLLLLLL",
"LLLLLLLLL.LLLLLLLLLLLLLLLL.LL.LLLLL.LLLLLLLLLLLLLLLLLLLLL..LLLLLLLLLLLLLL.LLLL.LLLL.LLLLLLLLLL",
"LLLLLLLLL.LLLLLLLLLLL..LLL.LLLLLLLLLLLLLLL.LLLLLLL.LLLLLL.LLLLLLLLLLLLL.L.LL.L..LLLLL.LLLLLLLL",
"LLLLLLLLL.LLLLLLLLLLL.LLLL.LLL.LLLLL.LLLLLLLL.LL.L.LLLLLL..LL.LLLLLL.LLLL..LLL.LLLLLL.LLLLLL.L",
"LLLLLLLL..LLLLL.LLLLL.LLLL.LLLLLLLLLLLLLLL.LLLLLLL.LL.LLL.LLLLLLLLLLLLLLL.LLLL.LLLL.LLLLLLLLLL",
"LLLLLLLLLLLLLLLLLLLLL.LLL..LLLLLL.LL.LLLLLLLLLLLLL.LLLLLLLLLLLLLL.LLLLLLL.LLLLLLLLL.LLLLLLLLLL",
".LLL..L..........L.LL.LL..L..L.....L.....L.....L..L..L....L..L..LL..L.L..L..LLL..LL...L.LLLLL.",
".LLLLLLLL.LL.L.LLLLLL.LLL..LLLLLLLLL.LLLLLLLLL.LLL.LLLLLLLLLL.L.L.LLLLLLLLLLLL.LLLLLLLLLLLLLLL",
"LLL.LLLLL.LLL.L.L.LLLLLLLL.LLLL.LLLL.LLLLLLLL...LL.LLLLLLLLLLLLLL.LLLLLLLLLL.L..LLL..LLLLLLLLL",
"LLLLLLLLLLLLLLLLLLLLL.L.LL.LLLLLLLLL.LLLLLLLL.LLLL.LLLLLL.LLLLLLLLLL.LLLLLLLLLLLLLL.LLLLLLLLLL",
"LLLLLLLLLLLLLLL.LLLLLLLLLL.LLLLLLLLL.LLLLLLLL.LLLL.LLLLLL.LLLLLLL.LLLLLLLLLLLL.LLLL.LLLLLLLLL.",
"LLLLLLLLL.LLLLL.LLLLL.LLLLLLLLLLLLLL.LLLLLLLL.LLLL.LLLLLL.LLLLLLLLLLLLL.L.LLLL.LLLL.LLLLLLLLLL",
"...LL.L......LL.......LLL...L.LL.LLL.L..L...L.L.LL...L.LLL.....L...L..L......L..LLLL........L.",
"LLLLLLLLL.LLLLLLLLLLL.LLLL.LLLLLLLLL.LLLLLL.L.LLLL.LL.LL..LLLL.LL.LLLLLLL.LLLL.LLLL..LLLL.LLLL",
"LLLLLLL.L.LLLLLLLLLLL.LLLL.LLLLLLLLLLLLLLLLLL.LLLL.LLLLLL.LLLLLLLLLLLLLLL.LLLL.LLLL.LLLLLL.LLL",
".LL.LLLLL.LLLLLLLLLLL.LLLLLLLLLLLLLL.L.LLLLLL.LLLL.LLL.LL.LLLLLLL.LLLLLLLLLLLLLLLLL.LLLLLLLLLL",
"LLLLLLLLL.LLLLLLLLLLL.LLLL.LLLLLLLL..LLLLLLLL.LLLL.LLLLLLLLLLLLLLLLL.LLLLLLLLL.LLLL.LLLLLLLLLL",
"LLLLLLLLLLLLLLLLLLLLL..LLL.LLLLLLLLL.L.LLLLLL.LLLL.LLLLLLLL.LLLLL.LLLLLLL.LLLL.LLLLLLLLLLLL.LL",
"LLLLLLLLL.LLLL..LLLLL.LLLL.LLLLLLLLLLLLLLL.LL.LLLL.LLLLLL.LL..LLLLLLLLLLL.LLLLLLLLL.LLLLLLLLLL",
"LL...L.L.LL.L....LL..L..L.L.LL.L..L.L...L.LL..L.L..L....L.....L.L.L.L.......L....L.....L..LLLL",
"LLLLLLLLL..LLLLLLLLLL.LLLL.LLLLLLLLLLLLLLLLLL.LLLLLLLLLLL.L.LLLLL.LLLLLL..L.LLLLLLLLLLLLLLLLLL",
"LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL.LL.LLLLLLLL.LLLL.LLLLLL.LLLLLLLLLLLLLLL..LLLLLLLLLLLLLLLLLLL",
"LLLLLLLLL.LLL.LLLLLL..LLLL.LLLLLLLLL.L.LLLLLL...LL.L.LLL..LLLLLLL.LLLLL.L.LLL.LLLLLLLLLLL.LLLL",
"LLLLLLLLLLLLLLL.LLLLL.LL.LLLLLLLLLLL.LLL.LLLL.LLLL.LLLLLL.LLLLLLL.LLLLLLL.LLLL.LLLL.LLLLLLLLLL",
"LLLLLLLLL.LLLLL.LLLLL.LLLL.LLLLLLLLLLLLL.LLLL.LLLL.LLLLLL.LLLLLLLLLLLLLLL.LLLLLLLLLLLLLLLLLLLL",
".L..LL.L.L......LL..L..L....LL.LLLLL.L.L.L.....L.L...LLL.LL...LL..L......L....L.LL..L...L.L...",
"LLLLLLLLL.LLLLL.LLLLL..LLL.LLLLLLLLL.LLLLLLLL.L.LL.LLLLLLLLL.LLLL.LLLLLLL.LLLLLLLLL.LLLLLLLLLL",
"LLLLLLLLLLLLLLL.LLLLLLLLLL.LLLLLLLLL.LLLLL.LL.LLLL.LLLLLLLLLLLLLL.LLL.LLL.LLLL.LLLL.LLLLLLLLLL",
".LLLLLLLL.LLLLL.LLLLL.LLLL.LLLLLLLLL.LLLLLLLL.LL..LLLLLLL.LLLLLLL.LLLLLLL.LLL..LLLL.L.LLLLLLLL",
"L.LLLLLLL.LLLLL.LLLLL.LLLLLLLLLLLLLL.LLLL.LLL.LL.L.LLLLLL.LLLLLLL.LLLLLLLLLLLLLLLLL.LLLLLLL.LL",
"LLLL.LLLLLLLLLL.LLLLL.LLLL.LLLLLLLL..LLLLLLLLLLLLL.LLLLLL.LLL.LLL.L.LLLLLLLLLL.LLLL.LLLLLLLLLL",
"LLLLLLLLL.LLLLL.LLLLLLLLL.LLLLLLLLLLL.LLLLLLLLLLLL.LLL.LL.LLLLLLL.LLLLLLL.LLLLLLLLL.LLLLLLLLLL",
"L.LLLLLLL.LLLLL.LLLLL.LLLLLLLLLLLLLLLLLLLLLLL.LLLLLLLLLLLLLLLLLLL.LLLLLLL.LLLLLLLLL.LLL.LLLL.L",
"LLLLLLLLL.LL.LL.LLLLL.LLLL.LLLLLLLLLLLLLLLLLL.LLLL.LLLLLL.LLLLL.L.LLLLLLLLLLLL.LLLL.LLLLLLLLLL",
"LL..L.L.LL..L..L.LLLLL.L.L......L..L.....L..LLL.L...LL.........L...L.........LL...LL...L..L...",
"L.LLLLLLLLLLL.L.LLLLLLLLLL.LLLLLLLLLLLLLLLLLLLLLLL.LLLLLL.LLLLLLL.LLLLLLLLLLLL.LLLL.LLLLLLLLLL",
"LLLLLLLLL..LLLL.LLLLL.LLLL.LLLLLLLLL.LLLLLLLL.LLLL.LLLLLL.LLLLLLLLLLLLLLL.LLL.LL.LLLLLLL.LLLLL",
"LLLLLLL.L.LLLLLLLLLLL.LLLL.LL.LLLLLL.LLLLLLLLLLLLL.LLLLLL.LLLLLLL.LLLLLLL.LLLLLLL.LLLLLLL.LLLL",
"LLLLLLLLL.LLLLL..LLLLLLLLL.LLLLLLLLL.LLLLL.LLLLLLL.LLLLLL.LLLLLLLLLLLLLLL.LLLL.LLLL.LLLLL.LLLL",
"LLLLLLLLL.LLLLL.LLLLL.LLLL.LLLLLLLLLLLLLLLLLL.LLLL.LL.LLLLLLLLLLL.LLLLLLL.L.LL.LLLL.LL.LLLLLLL",
"LLLLLLLLL.LLLLL.LLLLL.LLLL.LLLLLLLLLLLLLLLLLLLLL.L.LLLLLL.LLLLLLLLLL.LLLL.LLLL.LLLL.LLLLLLLLLL",
"LLLLLLLLL.LLLLLLLLLLL.LLLL.LLLLLLLLLLLLLLLLLL.LLLL.LLLLLL.LLLLLLLLL.LLLLL.LLLLLLLL.LLLLLLLLLLL",
"...L......L.L...L...L...LL..LL..LLLL..L....LLLL....L...L.L.....LL..LL...LL........LL..L.L...LL",
"LLLLLLLLLLLLLLL.LLLLL.LLLL.LLLLLLLLL.LL.LLLLL.LLLLLLLLLLL.LLLLLLL.LLLLLLL.LLLL.LLLL.LLLLLLLLLL",
"LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL.LLLLLLLLLLL.LLLLLLLLLLLLLLL.LLLLLLLL..LLL.LLLL.L",
"LLLLLLLLL.LLLLLLLLLLL.LLLLLLLLLLLLLL.LLLLLLLL.LLLL.LLLLLL.LLLLLLL.LLLLLLL.LLLLLLLLL.LLLLLLL.LL",
"LLLLLLLLLLLLLLL.LLLLLLLLLLLLLLLLLLLLLL.LL.LLL.L.LLLLLLLLL.LLLLLLLLLLLLLLLLLLLL.LLLL.LLLLLLLLLL",
"..L.L..LL.....L....LL.L.L.L..LLL......L..LLL..L..L....LL..L.LLL..L.....LL.L.L...........L..L..",
"LLLLLLLLLLLLLL.L.LLLL.LLLL.LL.LLLLLL.LLLLLLL..LLLL.LLLLLL.LLLLLLLLLLLLLLL.LLLL.LLLL.LLLLLL.L.L",
".LLLLLLLL.L.LLL.LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL.LLLLLLL.LLLLLLL.LLLLLLLLL.LLLLLLLLLL",
"LLL.LLLLLLLLLLLLLLLLL.LLLLLLLLLLLLLL.LLL.LLLLLLLLL.LL.LLL.LLLLLLL.LLLLLLL.LLLL.LLLL.LLLLLLLLL.",
"..LLLLLLL.LLLLLLLLLLL.LLLL.LLLLLLLLL.LLLLLLLL.LLLLLLLLLLL.LLLLLLL.LLLLLLL.LLLL.LLLL.LLLLLLLLLL",
".L..L..LL..L.L.L.L...L..LL............L..LL..LL.L.L.........LL.....L...L.L.LLL.L.L..........L.",
"LLLLLLLLL.LLLLLLLLLLLLLLLL.LLLLLLLLLLLLLLLLL..LLLL.LLLLLL.L.LLLLL.LLLLLLL.LLLL.LLLLLLLLLLLLLLL",
"LLLLLLLLL.LLLLL.L.LLL.LLLL.LLLLLLLLLLLLLLLL.L.LLLL..LLLLLLLLLLLLL.LLLLLLL.LLLL.LL.L.LLLLLL.LLL",
"LLLLLLLLL.LLLLL.LLLLL.LLLL.LLLLLLLLL.L.LLLLLL.LLLL.LLLL.L.LLLLLLL.LLLLLLLL.LLLLLLLL.LLLLLLLLLL",
"LLLLLLLLL.LLLLL.LLLLLLLLLL.LLLLLLLLL.LLLLLLLLLLLLL.LLL.LL.LLLLLLL.LLLLLLL.LLLL.LLLL.L.LLLLLLLL",
"LLLLLLLLLLLLLLLLLLLLL.LLLL..LL.LLLLLLL.LLLLLL.LLLLLLLLLLL.LL.LLLL.LLLLLLL.LLLLLLLLL.LLLLLLLLLL",
"LLLLLLLLLLLLLLL.LLLLLLLLLLLL.LLLLLLL.LL.LLLLLLLL.L.LLLLLL.LLLLLLL.LLL.L.LLLLLL.LLLL.LLLLLLLLLL",
"LLL.LLL.LLLLLLL.LLLLL..LLLLLLLLLLLLL.LLLLLLLLLLLL.LLLL.LL.LLLLLLL.LLLLLL..LLLLLLLLL.LLLLLLLLLL",
"....L.L..L.L..L....L.L..L............LL.............L......L.L....L....L..L.LL.........LLL..L.",
"LLLLLLLLL.LLLLL.LLLLL.LLLL.LLLLLLLLL.LLLLLLLL.LLLL.LLLLLL.LLLLLLL.L.LLLLLLLLLL.LLLL.LLLLLLLLLL",
"LLLLLLLLL.LLLLLLLLLLL.LLLL.LL.LLLLLLLLLLLLLLL.LLLL.LLLLLLLLLLLLLLLLLLLLLL..LLL.LLLL.LLLLLL.LLL",
"LLLLLLLLL.LLLLL.LL.LLLLLLL.LLLLLLLLLLLLLLLLL.LLLLL.LLLLLLL.LLLL.L.LLLLLLL.LLLL.LLLLLLLLLLLLLLL",
"LLLLLLLLL.LL..LLLLLLLLLLLL.LLLLLLLLLLLLLLLLLL.LLLL.LLLLLLL.LLLLL..LLLLLLL.LLLLLLLLL.LLLLLLL.LL",
".LL..L..L..LLL...L..LL.L...LL..L.....L.L...L.L...L.L..L.L........L.L..L.L..L....L.....L..L..LL",
"LLLLLLLLL.LLLLLLLLLL..LLLL.LLLLLLLLL.LLLLLLLL.LLLL.LLLLLL.LLLLLLLLLLLLLLL.LLLL.LL.L.LL.LLLLLLL",
"LLLLLLLLL.LLL.L.LLLLLLLLLL.L.LLLLLLLLLLLLLLLLLLLLL.LL.LLL.LLLLLLL.LLLLL.LLL.LL.LLLL.LLLLLLLLLL",
"LLLLLLLLLLLLLLLLLLLLL.LLLL.LLLLLLLLL.LLLLLLL.LLLLL.LLLLLL.LLLLLLL..LL.LLLLLLLLLLLLL.LLLLLLLLLL",
"LLLLLLLLL.LLLLL.LLLLLLLLLLLLLLLLLL.LLLLLLLLLL.LLLLLLLLLLL.LLLLLLL.LLLLLLLLLLLL.LLLL.LLLLLLLLLL",
"LLL.LLLLLLLL.LL.LLLLL.LLLL.LLLLLLLL.LLLLLLLLL.LLLL.LLLLLL.LLLLLLL.LLLLLLL.LLLL.LLLL.LLLLLLLLLL",
"LLLLLLLLL.LLLLL.LLLLL.LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL.LLLLLLL.LLLLLLL.LLLL.LLLL.LLLLLLLLLL",
"..L....L........L....LL..L...LL.L.....L.LL.L..L....L....LL......L.L.....L.L..LL..L.....L.LLL.L",
"LLLLLLLLL.LLLLL.LLLLL.LLLL.LLLLLLLLL.LLLLLLLL.LLLL.LLLLLL.LLLLLLLLLLLLLLL.LLLL.LLLL.LLLLLLLLLL",
"LLLLL.LLLL.LLLLLLLLLL.LLLL.L.LLLLLLL.LLLLLLLL.LLLL.L.LLLL.LLLLLLLLLLLLLLLLLLLLLLLL..LLLLLLLLLL",
"LL.LLLLLL.LLLLL.LLL.LL.LLL.LLLLLLLLL.LLLLLLLL.LLLL.LLLLLL.LLL.LLL.LLLLLLLLLLLL.LLLL.LLLLLLLL.L",
"LLLLLLLLLLLLLLL.LLLLL.LLLL.LLLLLLL.LLLLLLLLLL.LLLLLLLLLLL.LLLLLL.L.LLLLLL.LLLL.LLLL.LLLLLLL.LL",
"LLL.LLLL..LLLLLLLLLLL.LLLL.LLLLLLLLL..LLLLLLLLLLLL.LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL",
"LLLLLLLLLLLLLLL.LLLLL..LLLLLLLLLLLLL.LLLLLLLLL.LLL.LLLLLL.LLLLLLL.LLLLLLLLLLLL.LLL..LLLLLLLLLL",
"LLLLLLLLL.LLLLL.LLLLL.LLLL.LLLLLLLLL.LLLLLLLL.LLLL.LLLLLL..LLLLLL.LLLLLLLLL.LLLLLLLLLLLLLLLLLL",
"LLLLLLLLL.LLL.LLLLLLL.LLLLLLLLLLLLLL.LLLLLLLLLLLLL.LLLLLL.LLLLL.L.LL.LLLLL.LL.LLLLLLL.LLLLLLLL",
"LLLLLLLLLLL.LLL.LLLLLLLLLL.LLLLLLLLL.LLLLLLLL.LLLL.LLLLLL.LLLLLLL.LLLLLLL.LLLL.LLLLLLLLLLLLL.L",
"...LL.L..L...LL...LLL.........L.L.L..L.....LLLL.LL....L..L...L...LL..L..L......L..LLLL....L..L",
"LLLLLLLLLLLLLLL.LLLLL.LLLLLLLLL.LLLL.L.LLLLLL.LLLL.LLLL.L.LLL.LLLLLLLLLLL.LLLL.LLLL.LLLLLLLLLL",
"LLLLL.LLL.LLL.L.LL.LL.LLLL.LLLLLLLLLLLLLLLLLL.LLLL.LLLLLLL.LLLL.L.LLLLLLL..LLL.LLLL.L.LLLLLLLL",
"LLLLLLLLLLLLL.L.LLLLL.LLLLL.LLLLLLLL.LLLLLLLLLLLLL..LL.L..LLLLLLL.LLLL.LL.LLLL.LLLL.LLLLLLLLLL",
"LLLLLLLL..LLLLLLLLLLL.L.LLLLLLLLLLLLLLLLLLLLLLLLLL.LLLLLL.LLLLLLL..LL.LLLLLL.L..LLL.LLLLLLLLLL",
"LLLLLLLLLLLLLLL.LLLLL.LLLL.LLLLLLLLL.LLLLLLLL.LLLLLLLLLLLLLLLLLLL.LLLLLLL.LLLL.LLLL.L.LLLLLLLL",
".L....L.LL...L...LL......LL..........L.LLL...L...L..........L.........LL..L.L.L...L..L........",
"LLLLLLLLL.LLLLLLLLL.L.LLLL.LLLLLLLLL.LLLLLLLLLLLLL.LLLLLL.LLLLLLL.LLLLLLLLLLLL.LLLL..LLLLLLLLL",
"LLLLLLLLL.LLLLL.LL.LL.LLLL.LLLL.LLLL.LLLLLLLL.LLLL.LLLLLL.LLLLLLL.LLLLLLL.LLLL.LLLL.LLLLLLLLLL",
"LL.LLLLLL.LLLLL.LLLLL.LLLL.LL.LLLLLL.LLLLL.LL.LLLL.LLLLLLLLLLLLLL.LLLLLLLLLLLL.LLLLL.LLLLLLLLL",
"LLLLLLLLL.LLLLL.LLLLL.LLLL.LLLLLLLLL.LL.LLLLL.LLLL.LL.LLLLLL.LLLL.LLLLLLL.LLLLLLLLLLLLLLLLL.LL",
"LLLLLLLLL.LLLLLLLLLLL.LLLLLLLLLLL.LLLLLLLLLLL..LLL.LLLLLL.LLLLLLL.LLLLLLL.LLLL.LL.LLLLLLLLLLLL",
"LLLLLLLLLL.L.LL.LLLLL.LLLL.LLLLLLLLLLLLLLLLLL.LLLL.LLLLLL.LLLLLLL.L.LLLLL.LLLL.LLLLLLLLLLLLLLL"};

            char[,] seatCharArray = new char[97, 94];
            bool aSingleChange = true;
            int iterations = 0;
            // Create double char array
            for (int a = 0; a < 97; a++)
            {
                for (int b = 0; b < 94; b++)
                {
                    seatCharArray[a, b] = seats[a][b];
                }
            }
            char[,] calculatedCharArray = seatCharArray.Clone() as char[,];
            while (aSingleChange == true)
            //while (iterations < 4)
            {
                aSingleChange = false;

                for (int i = 0; i < 97; i++)
                {
                    for (int j = 0; j < 94; j++)
                    {
                        int occupiedSeats = 0;

                        // Check for an empty seat
                        if (seatCharArray[i, j] == char.Parse("L"))
                        {
                            // Check around
                            for (int k = -1; k < 2; k++)
                            {
                                for (int l = -1; l < 2; l++)
                                {
                                    int sight = 1;
                                    // Don't check yourself
                                    if (k == 0 && l == 0) continue;
                                    while (true)
                                    {
                                        // If out of bounds, continue
                                        if (i + (k * sight) == -1)
                                        {
                                            Console.WriteLine("Left edge");
                                            break;
                                        }
                                        if (i + (k * sight) == 97)
                                        {
                                            Console.WriteLine("Right edge");
                                            break;
                                        }
                                        if (j + (l * sight) == -1)
                                        {
                                            Console.WriteLine("Top edge");
                                            break;
                                        }
                                        if (j + (l * sight) == 94)
                                        {
                                            Console.WriteLine("Bottom edge");
                                            break;
                                        }                                        // If we see a dot, increase sight and continue
                                        if (seatCharArray[i + (k * sight), j + (l * sight)] == char.Parse("."))
                                        {
                                            sight++;
                                            continue;
                                        }
                                        // If a chair is occupied, increment occupied seats and break
                                        if (seatCharArray[i + (k * sight), j + (l * sight)] == char.Parse("#"))
                                        {
                                            occupiedSeats++;
                                            break;
                                        }
                                        // If a chair is empty, just break
                                        if (seatCharArray[i + (k * sight), j + (l * sight)] == char.Parse("L"))
                                        {
                                            break;
                                        }
                                    }
                                }
                            }
                            // Sit
                            if (occupiedSeats == 0)
                            {
                                calculatedCharArray[i, j] = char.Parse("#");
                                Console.WriteLine(occupiedSeats);
                                aSingleChange = true;
                            }
                        }
                        // Check for an occupied seat
                        if (seatCharArray[i, j] == char.Parse("#"))
                        {
                            // Check around
                            for (int k = -1; k < 2; k++)
                            {
                                for (int l = -1; l < 2; l++)
                                {
                                    int sight = 1;
                                    // Don't check yourself
                                    if (k == 0 && l == 0) continue;
                                    while (true)
                                    {
                                        // If out of bounds, continue
                                        if (i + (k * sight) == -1)
                                        {
                                            Console.WriteLine("Left edge");
                                            break;
                                        }
                                        if (i + (k * sight) == 97)
                                        {
                                            Console.WriteLine("Right edge");
                                            break;
                                        }
                                        if (j + (l * sight) == -1)
                                        {
                                            Console.WriteLine("Top edge");
                                            break;
                                        }
                                        if (j + (l * sight) == 94)
                                        {
                                            Console.WriteLine("Bottom edge");
                                            break;
                                        }                                        // If we see a dot, increase sight and continue
                                        if (seatCharArray[i + (k * sight), j + (l * sight)] == char.Parse("."))
                                        {
                                            sight++;
                                            continue;
                                        }
                                        // If a chair is occupied, increment occupied seats and break
                                        if (seatCharArray[i + (k * sight), j + (l * sight)] == char.Parse("#"))
                                        {
                                            occupiedSeats++;
                                            break;
                                        }
                                        // If a chair is empty, just break
                                        if (seatCharArray[i + (k * sight), j + (l * sight)] == char.Parse("L"))
                                        {
                                            break;
                                        }
                                    }
                                }
                            }

                            // Get up
                            if (occupiedSeats >= 5)
                            {
                                calculatedCharArray[i, j] = char.Parse("L");
                                aSingleChange = true;
                                Console.WriteLine(occupiedSeats);
                            }
                        }
                    }
                }
                // Output to console
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                for (int m = 0; m < 97; m++)
                {
                    for (int n = 0; n < 94; n++)
                    {
                        Console.Write(calculatedCharArray[m, n]);
                    }

                    Console.WriteLine();
                }
                seatCharArray = calculatedCharArray.Clone() as char[,];
                iterations++;

            }
            Console.WriteLine("YOU GET A COOKIE!!!");
            int finalSeats = 0;
            for (int o = 0; o < 97; o++)
            {
                for (int p = 0; p < 94; p++)
                {
                    if (calculatedCharArray[o, p] == char.Parse("#")) finalSeats++;
                }

            }
            Console.WriteLine("Final answer: " + finalSeats);

        }
    }
}
