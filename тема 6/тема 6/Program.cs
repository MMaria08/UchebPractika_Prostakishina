using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace тема_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var culture = CultureInfo.InvariantCulture;           
            Console.WriteLine("1. Parse");
            string s1 = "17:39";
            DateTime d1 = DateTime.Parse(s1, culture);
            Console.WriteLine($"Было :(\"{s1}\"), стало: {d1:HH:mm:ss}");

  
            Console.WriteLine("2. ParseExact");
            string s2 = "18-45-30";                     
            DateTime d2 = DateTime.ParseExact(s2, "HH-mm-ss", culture);
            Console.WriteLine($"Было(\"{s2}\", \"HH-mm-ss\"), стало: {d2:HH:mm:ss}");

            
            Console.WriteLine("3. TryParse");
            string s3 = "7:15 AM";
            if (DateTime.TryParse(s3, culture, DateTimeStyles.None, out DateTime d3))
                Console.WriteLine($"Было: (\"{s3}\"), стало:{d3:HH:mm}");
            else
                Console.WriteLine($"{s3} - ошибка, не удалось");

            string s4 = "28:87";                        
            if (DateTime.TryParse(s4, culture, DateTimeStyles.None, out DateTime d4))
                Console.WriteLine($"Было: (\"{s4}\"), стало:{d4:HH:mm}");
            else
                Console.WriteLine($"{s4} - ошибка, не удалось");

           
            Console.WriteLine("4. TryParseExact");

            string s5 = "23:59";
            if (DateTime.TryParseExact(s5, "HH:mm", culture, DateTimeStyles.None, out DateTime d5))
                Console.WriteLine($"Было: (\"{s5}\", \"HH:mm\"), стало:{d5:HH:mm}");
            else
                Console.WriteLine($"{s5}, \"HH:mm\" - ошибка, не подошло под шаблон");

            string s6 = "23_59";                  
            if (DateTime.TryParseExact(s6, "HH:mm", culture, DateTimeStyles.None, out DateTime d6))
                Console.WriteLine($"TryParseExact(\"{s6} \") -> УСПЕХ, время =  {d6:HH:mm}");
            else
                Console.WriteLine($"{s6}, \"HH:mm\" - ошибка, не подошло под шаблон");
        }
        }
}
