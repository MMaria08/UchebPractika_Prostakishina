using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace работа_со_123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число n: ");

            try
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int b = Math.Abs(n - 123);

                if (n > 123)
                { 
                    b *= 3;

                Console.WriteLine($"Результат: {b}");
                }

                Console.WriteLine($"Результат: {b}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введено не целое число.");
            }
        }
    }
    }

