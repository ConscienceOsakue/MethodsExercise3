using System;
using System.Collections.Generic;

namespace MethodsExercise3
{
    class Program
    {
       
            static void DisplayMultiplicationTable(int number)
            {
                //Write a method to display a given integer's multiplication table(from 1 to 12).

                for (int i = 1; i <= 12; i++)
                {
                    Console.WriteLine($"{number} x {i} = {number * i}");
                }
            }

            static void Main()
            {
                Console.WriteLine("Enter a number to display its multiplication table:");

                int num = Convert.ToInt32(Console.ReadLine());
                DisplayMultiplicationTable(num);
            }
    }
}
