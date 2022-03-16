using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class IO9
    {
        public static void main()
        {
            int Num = 0, answer = 0;

            try
            {
                Console.Write("Write the number : ");
                Num = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            answer = Num + 2;
            answer = answer - answer % 2;

            Console.Write(answer);
        }
    }
}
