using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicalpractice
{
    class Factorial
    {

        public static void Main(string[] args)
        {

            int fact = 1, number;
            Console.WriteLine("Enter the number ");
            number = int.Parse(Console.ReadLine());
            for(int i = 1; i <= number; i++)
            {
                fact = fact *i;

            }
            Console.WriteLine("factorial is  "+fact);
        }

    }
}
