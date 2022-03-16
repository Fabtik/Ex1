using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class IO16
    {
        public static void main()
        {
            double n = 0, m = 0;

            try
            {
                Console.Write("Write n ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.Write("Write m ");
                m = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            
            Console.WriteLine(Math.Ceiling(m/n));
        }
    }
}
