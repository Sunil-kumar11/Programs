using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicalpractice
{
    class Palindrome
    {

        public static void Main(string[] args)
        {

            int  numbeer, r, sum = 0, temp;
            Console.Write("Enter the Number : ");
            numbeer = int.Parse(Console.ReadLine());
            temp = numbeer;
            while (numbeer > 0)
            {
                r = numbeer % 10;
                sum = (sum * 10) + r;
                numbeer = numbeer / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("The given number is palindrome");
            }
            else
            {
                Console.WriteLine("The given number is not palindrome");
            }
        }

    }
}
