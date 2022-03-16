using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class IO13
    {
        public static void main()
        {
            var time = new DateTime(2022, 1, 1, 9, 0, 0);
            int n = 0, mm=0;

            try
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }
            
            mm = n * 45 + (n / 2) * 5 + ((n + 1) / 2 - 1) * 15;

            Console.WriteLine($"{time.AddMinutes(mm):t}") ;
        }
    }
}
