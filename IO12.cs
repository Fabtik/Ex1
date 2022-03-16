using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class IO12
    {
        public static void main()
        {
            int a = 0, b = 0;

            try
            {
                Console.Write("Write a ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Write b ");
                b = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }
            
            Console.WriteLine("a = " + a + "  " + "b = " + b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("a = " + a + "  " + "b = " + b);

        }
    }
}
