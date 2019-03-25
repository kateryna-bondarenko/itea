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
            Console.WriteLine("Напиши цифру от 1 до 7");
            WriteColor();
            Console.ReadLine();
        }
        
        public static void WriteColor()
        {
            int a = int.Parse(Console.ReadLine());

            if (a == 1)
                {
                    Console.WriteLine("Красный");
                }

            else if (a == 2)
            {
                Console.WriteLine("Оранжевый");
            }

            else if (a == 3)
            {
                Console.WriteLine("Желтый");
            }

            else if (a == 4)
            {
                Console.WriteLine("Зелёный");
            }

            else if (a == 5)
            {
                Console.WriteLine("Голубой");
            }

            else if (a == 6)
            {
                Console.WriteLine("Синий");
            }

            else if (a == 7)
            {
                Console.WriteLine("Фиолетовый");
            }

            else
                {
                    Console.WriteLine("Что-то пошло не так");
                }

                Console.ReadLine();
            
        }
     }
    
}
