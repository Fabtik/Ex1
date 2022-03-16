using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class IO18
    {
        public static void main()
        {
            double h = 0, a = 0, b = 0;
            int Answer = 0;
            try
            {
                Console.Write("h = ");
                h = Convert.ToInt32(Console.ReadLine());
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

            Answer = (int)Math.Ceiling((h - 2 * b + a - 1) / (a - b));

            Console.WriteLine(Answer);
        }
    }
}
