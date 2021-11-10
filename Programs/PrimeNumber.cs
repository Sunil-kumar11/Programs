using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class PrimeNumber
    {

        int num1, num2;
        Console.Write("enter the num 1 :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the num 2 :");
            num2 = Convert.ToInt32(Console.ReadLine());

            num1 = num1* num2;
        num2 = num1 / num2;
            num1 = num1 / num2; 

            Console.WriteLine("Swap num1 :" + num1 + "Swap num2 :" + num2);




    }
}
