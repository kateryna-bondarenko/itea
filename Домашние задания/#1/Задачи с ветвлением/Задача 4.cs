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
            Console.WriteLine("25-13=?");
            WriteNumber();
            Console.ReadLine();
        }
        
        public static void WriteNumber()
        {
            int a = int.Parse(Console.ReadLine());

            if (a==12)
                {
                    Console.WriteLine("Правильно, 12");
                }

                else
                {
                    Console.WriteLine("Неправильно");
                }

                Console.ReadLine();
            
        }
     }
    
}
