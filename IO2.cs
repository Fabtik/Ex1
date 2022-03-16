using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class IO2
    {
        public static void main()
        {
            double Num = 0;
            Console.Write("Write number: ");
            try
            {
                Num = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            Console.WriteLine("The next number for the number " + Num + " is " + (Num + 1) + "." + "\n" 
                + "The previous number for the number " + Num + " is " + (Num - 1) + ".");

        }
    }
}
