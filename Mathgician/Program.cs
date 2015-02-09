using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathgician
{
    [System.Runtime.InteropServices.GuidAttribute("1E17A022-586C-408D-98D2-09B224599EB9")]
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I AM THE MATHGICIAN!");
            Console.WriteLine("What shall I math?\nFibonacci, Primes, or Integers");
            string desiredMaths = Console.ReadLine();
            Console.WriteLine("Ok. I'm gonna some " + desiredMaths);
            if ("Integers" == desiredMaths)
            {
                PrintIntegers();
            }
            else if ("Fibonacci" == desiredMaths)
            {
                PrintFibonacciSequence();
            }
            else if ("Primes" == desiredMaths)
            {
                PrintPrimes();
            }
            else {
                Console.WriteLine("Well, actually, I lied");
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        private static void PrintFibonacciSequence()
        {
            //1, 3, 5, 8, 13, 
            int previous = 0;
            int current = 1;
            while (true)
            {
                Console.WriteLine(current);
                System.Threading.Thread.Sleep(100);
                int newValue = previous + current;
                previous = current;
                current = newValue;
            }
        }

        private static void PrintIntegers()
        {
            int nextInteger = 0;
            while (true)
            {
                nextInteger++;
                Console.WriteLine(nextInteger);
            }
        }
        private static void PrintPrimes()
        {
            int i = 2;
            var NumbersToCheck = new List<int> { };
            while (true)
            {
                bool found = false;
                for (int y = i - 1; y > 1; y--)
                {
                    if (i % y == 0)
                    {
                        found = true;
                    }
                }
                foreach (int number in NumbersToCheck)
                {
                    int answer = (i / number) % 1;
                    if (answer != 0)
                    {
                        found = true;
                    }

                }
                if (found == false)
                {
                    Console.WriteLine(i);
                    System.Threading.Thread.Sleep(25);
                    NumbersToCheck.Add(i);
                }
                i++;
            }
        }
    }

}
