using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class IO14
    {
        public static void main()
        {
            int a = 0, b = 0, n = 0;

            try
            {
                Console.Write("Write a ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Write b ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Write n ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            a *= n;
            b *= n;
            while (b > 99)
            {
                a += 1;
                b -= 100;
            }
            

            Console.WriteLine(a + " " + b);

        }
    }
}
