using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class IO10
    {
        public static void main()
        {
            int n = 0, minutes, hours;
        M1:
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
           

            if (n < 0)
            {
                Console.WriteLine("Error, the number of minutes is incorrect");
                goto M1;
            }
            while (n > 1440)
            {
                n -= 1440;
            }
            minutes = n % 60;
            hours = n / 60;

            Console.Write(hours + " " + minutes);
        }
    }
}
