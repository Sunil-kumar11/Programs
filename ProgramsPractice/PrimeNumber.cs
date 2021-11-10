using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsPractic
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            int i, m, n, flog = 0;
            Console.Write("check number prime or not : ");
            n = Convert.ToInt32(Console.ReadLine());
            m = n / 2;
            if(n == 0 || n == 1)
            {
                Console.WriteLine("the given number is not prime number");
                
            }
            else
            {
                for (i = 2; i <= m; i++)
                {
                    if(n%i == 0)
                    {
                        Console.WriteLine("is not prime number");
                            flog = 1;
                        break;
                        
                    }
                    
                }
                if (flog == 0)
                {
                    Console.WriteLine("is not prime number");
                }
            }
            
        }

    }   
}
