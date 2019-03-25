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
            Console.WriteLine("Я загадала число от 1 до 10, попробуй угадать");
            WriteNumber();
            Console.ReadLine();
        }
        
        public static void WriteNumber()
        {
            int n = int.Parse(Console.ReadLine());

            
                if (n >= 0 && n <= 3)
                {
                    Console.WriteLine("Очень холодно!");
                }

                else if (n > 3 && n <= 6)
                {
                    Console.WriteLine("Почти! Уже теплее");
                }

                else if (n > 6 && n < 10)
                {
                    Console.WriteLine("Горячо! Уже совсем близко");
                }

                else if (n == 10)
                {
                    Console.WriteLine("Молодец! Ты угадал");
                }

                else
                {
                    Console.WriteLine("Перечитай задание");
                }

                Console.ReadLine();
            
        }
     }
    
}
