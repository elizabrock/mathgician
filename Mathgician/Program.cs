using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathgician
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I AM THE MATHGICIAN");
            Console.WriteLine("What shall I math?\nFibonacci, Primes, or Integers");
            string desiredMaths = Console.ReadLine();
            Console.WriteLine("Ok.  I'm gonna do some " + desiredMaths);
            if ("Integers" == desiredMaths)
            {
                PrintIntegers();
            }
            else
            {
                Console.WriteLine("Well, Actually... I Lied..");
            }
            Console.WriteLine("Press Any Key To Exit...");
            Console.ReadKey();
        }

        private static void PrintIntegers()
        {
            int nextInteger = 0;
            while(true)
            {
                nextInteger++;
                Console.WriteLine(nextInteger);
            }
        }
    }
}
