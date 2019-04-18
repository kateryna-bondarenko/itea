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
            Console.WriteLine("Введи два числа");
            WriteNumber();
            Console.ReadLine();
        }
        
        public static void WriteNumber()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a>b)
                {
                    Console.WriteLine((a+b)/(a-b));
                }

                else
                {
                    Console.WriteLine(a*b);
                }

                Console.ReadLine();
            
        }
     }
    
}
