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
            Console.WriteLine("Напиши свой возраст и затем возраст своего друга");
            WriteNumber();
            Console.ReadLine();
        }
        
        public static void WriteNumber()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a>b)
                {
                    Console.WriteLine("Ты старше своего друга на " + (a-b) + " года");
                }

                else
                {
                    Console.WriteLine("Ты младше своего друга на " + (b - a) + " года");
                }

                Console.ReadLine();
            
        }
     }
    
}
