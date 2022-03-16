using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class IO11
    {
        public static void main()
        {
            int temp = 0, n = 0, hh = 0, mm = 0, ss = 0;
            Console.Write("Write the number of seconds ");

            Console.Write("Write the number of minutes ");
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            for (int i = 0; i < n; i++)
            {
                if (temp == 60)
                {
                    mm++;
                    temp = 0;
                }
                if (mm == 60)
                {
                    hh++;
                    mm = 0;
                }
                if (hh == 24)
                {
                    hh = 0;
                }
                temp++;
            }
            ss = temp;

            Console.WriteLine(T(hh) + hh + ":" + T(mm) + mm + ":" + T(ss) + ss);
        }

        static string T(int n)
        {
            if (n / 10 > 0)
            {
                return "";
            }
            return "0";
        }

    }
}
