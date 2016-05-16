using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dayEightOneToNPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value for 'n' greater than 1");
            int n = int.Parse(Console.ReadLine());

            for (int counter = 1; n >= counter; counter++)
            {
                if ((counter % 3) == 0 && (counter % 7 == 0))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(counter);
                }
            }
        }
    }
}
