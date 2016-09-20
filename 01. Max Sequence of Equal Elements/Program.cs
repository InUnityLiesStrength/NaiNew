using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numInput = Console.ReadLine().Split().Select(int.Parse).ToList();
        
        List<int> result = new List<int>();
        int winNumber = numInput[0];
        int counter = 1;
        int maxCounter = 1;

        for (int i = 1; i < numInput.Count; i++)
        {
            if (numInput[i] == numInput[i - 1])
            {
                counter++;
                if (counter > maxCounter)
                {
                    winNumber = numInput[i];
                }
            }
            else
            {
                counter = 1;
            }

            maxCounter = Math.Max(maxCounter, counter);

        }

        for (int i = 0; i < maxCounter; i++)
        {
            Console.Write(winNumber + " ");
        }
    }
}