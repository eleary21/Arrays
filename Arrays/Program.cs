//Author: Ethan Leary
//Date: 2/5/2021
//Comments: Execute an array and display the results to the console
using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
           //Declare array
            int[] numbersArray;
            //Create array with integers
            numbersArray = new int[26];
            //assign value and print each value
            for (int index = 1; index < numbersArray.Length; index++)
            {
                numbersArray[index] = index;
                Console.WriteLine("Element Value = " + numbersArray[index]);
            }
            Console.ReadKey(true);
        }
    }
}
