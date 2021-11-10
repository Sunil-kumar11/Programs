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

            Console.WriteLine("enter a num1");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter a num2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("num1 : {0} num2 :{1}", num1, num2);
            num1 = num2-num1;
            num2 = num2-num1;
            num1 = num1 + num2;
            Console.WriteLine("num1 : {0} num2 :{1}", num1, num2);
            num1 = num1 * num2;
            num2 = num1 / num2;
            num1 = num1 / num2;
            Console.WriteLine("num1 : {0} num2 :{1}", num1, num2);

        }
    }
}
