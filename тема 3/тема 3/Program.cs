using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLab;

namespace тема_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FirstClass s = new FirstClass();

            s.Hello();             
            s.Show(42);             

            Console.WriteLine(s.Sum(3, 4));        
            Console.WriteLine(s.Half(10));          
            Console.WriteLine(s.Plus(-5));   
        }
    }
}
