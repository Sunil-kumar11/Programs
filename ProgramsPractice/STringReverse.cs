using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsPractic
{
    class STringReverse
    {
        static void Main(string[] args)
        {
            string reverse = "";
            Console.Write("Enter a string :");
            string str1 = Console.ReadLine();

            string[] arr = str1.Split();

            for (int i =arr.Length-1;i>=0; i--)
            {
                reverse =reverse +"  "+ arr[i];
            }
            Console.WriteLine(reverse);
           
        }
    }
}
