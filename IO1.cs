using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class IO1
    {
        public static void main()
        {
            double a = 0, b = 0, c = 0;

            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            c = Math.Sqrt(a * a + b * b);
            Console.WriteLine("C = " + Convert.ToString(c));
        }
    }
}
