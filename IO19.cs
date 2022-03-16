using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class IO19
    {
        public static void main()
        {
            double n = 0;
            try
            {
                Console.Write("n = ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            int n1, n2, n3, n4;
            n1 = (int)(n/1000);
            n2 = (int)((n / 100) % 10);
            n3 = (int)((n/10)%10);
            n4 = (int)(n % 10);

            Console.WriteLine((((n1-n4)+(n2-n3)) + 1));
        }
    }
}
