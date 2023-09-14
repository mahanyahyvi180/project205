using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp135
{
    class Program
    {
        static void Main(string[] args)
        {
            for (long counter = 0; counter < +10; ++counter)
            {
                Console.WriteLine($"{counter}!={Factorial(counter)}");
                Console.ReadLine();
            }
        
        }

        static long Factorial(long number)
        {
            if (number <= 1)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }
    }
}
