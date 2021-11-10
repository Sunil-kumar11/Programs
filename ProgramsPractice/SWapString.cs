using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsPractic
{
    class SWapString
    {


        static void Main(string[] args)
        {
            Console.WriteLine("enteter string 1 :");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter a second string 2 :");
            string str2 = Console.ReadLine();

            string temp = str1;
            str1 = str2;
            str2 = temp;

            Console.WriteLine("swap str1 :" + str1 + "  swap str2 : " + str2);

        }
    }
}
