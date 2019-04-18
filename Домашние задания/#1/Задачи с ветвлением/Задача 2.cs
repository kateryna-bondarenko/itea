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
            Console.WriteLine("Введи любую букву");
            WriteLetter();
            Console.ReadLine();
        }
        
        public static void WriteLetter()
        {
            char a = char.Parse(Console.ReadLine());

            
                if (char.IsLower(a))
                {
                    Console.WriteLine("Ты ввёл строчную букву");
                }

                else
                {
                    Console.WriteLine("Ты ввёл прописную букву");
                }

                Console.ReadLine();
            
        }
     }
    
}
