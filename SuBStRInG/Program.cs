﻿using System;

namespace SuBStRInG
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloWorld = "Hello World!";
            string partToLookFor = "Hello";
            bool isThere;
            isThere = helloWorld.ToLower().Contains(partToLookFor);
            if (isThere)

            {
                Console.WriteLine($"Leidsin {partToLookFor} üles!");


            }
            else
            {
                Console.WriteLine($"Ei leidnud {partToLookFor}");
            }
         



        }
    }
}
