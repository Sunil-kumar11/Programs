﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicalpractice
{
    class Fibonacci
    {

        public static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, i, number, n3;
            Console.Write("Enter the number :  ");
            number = int.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " ");
            for (i = 2; i < number; ++i)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;

            }

        }

            
    }
}
