using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that traverses through a list of numbers from 1 -100.
            //If a number is divisible by 3, Print out "Fizz".
            //If a number is divisible by 5, Print out "Buzz".
            //If neither of the two conditions match, print the number.
            for (int i = 0; i <= 100; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }

        }
    }
}
