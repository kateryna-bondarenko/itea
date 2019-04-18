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
            WriteYourAge();
            Console.ReadLine();
        }
        
        public static void WriteYourAge()
        {
            int Age = int.Parse(Console.ReadLine());

            if (Age <= 16)
            {
                Console.WriteLine("Too young!");
            }

            if (Age > 16 && Age <= 50)
            {
                Console.WriteLine("Adult");
            }

            if (Age > 50 && Age <= 90)
            {
                Console.WriteLine("Senior");
            }

            if (Age > 90)
            {
                Console.WriteLine("Old");
            }

            Console.ReadLine();
        }
     }
    
}
