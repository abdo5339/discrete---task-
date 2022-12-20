using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_number
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the lower bound of the range: ");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the upper bound of the range: ");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine("The prime numbers in the range are: ");
            for (int i = start; i <= end; i++)
            {
                bool isPrime = true;

                if (i == 2 || i == 3)
                {
                    Console.WriteLine(i);
                }
                else if (i == 1 || i % 2 == 0)
                {
                    continue;
                }
                else
                {
                    for (int j = 3; j <= Math.Sqrt(i); j += 2)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime)
                    {
                        Console.WriteLine(i);
                    }
                }

            }

        }
    }
}

