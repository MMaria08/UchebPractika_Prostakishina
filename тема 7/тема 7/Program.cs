using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема_7
{
    internal class Program
    {
        static int[] SortAscending(int[] source)
        {
            int[] result = (int[])source.Clone();
            Array.Sort(result);
            return result;
        }
        static int[] SortDescending(int[] source)
        {
            int[] result = (int[])source.Clone();
            Array.Sort(result);
            Array.Reverse(result);
            return result;
        }
        static int[] Unit(int[] a, int[] b)
        {
            int[] result = new int[a.Length + b.Length];
            Array.Copy(a, 0, result, 0, a.Length);
            Array.Copy(b, 0, result, a.Length, b.Length);
            return result;
        }        
       
    
     static void Main()
        {
            int[] a = { 235, 62, 87, 12, 98 };
            int[] b = { 57, 43, 64, 48, 30 };

            Console.WriteLine($"Исходный A: [{string.Join(", ", a)}]");
            Console.WriteLine($"Исходный B: [{string.Join(", ", b)}]");

            Console.WriteLine($"A по возрастанию: [{string.Join(", ", SortAscending(a))}]");
            Console.WriteLine($"A по убыванию: [{string.Join(", ", SortDescending(a))}]");
            Console.WriteLine($"A + B: [{string.Join(", ", Unit(a, b))}]");
        }


    }
    } 

