using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    

    class IO21
    {
        public static void main()
        {
            double a = 0, b = 0;
            try
            {
                Console.Write("a = ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("b = ");
                b = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            Console.WriteLine((a + b + Math.Abs(a - b)) / 2);
        }
    }
}
