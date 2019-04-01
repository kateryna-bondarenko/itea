using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напиши любое число от 0 до 100");
            WriteNumber();
            Console.ReadLine();
        }
        
        public static void WriteNumber()
        {
            int a = int.Parse(Console.ReadLine());

            if ((a/2)>0)
                {
                    Console.WriteLine(a/2);
                }

				//Is this the same as 0<a<=50, if so, write a simple version,
				//remember that you are writing code to be read by not for machine, but by human being.
            else if ((a+50)>50 && (a+50)<=100)
            {
                Console.WriteLine(a+50);
            }

            else if (a==100)
            {
                Console.WriteLine(a);
            }

            else if (a == 0)
            {
                Console.WriteLine("А почему 0?");
            }

            else
                {
                    Console.WriteLine(a+5-34+7);
                }

                Console.ReadLine();
            
        }
     }
    
}
