using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class IO8
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
            int CopyNum = Num; // Не хочу терять число которое ввел юзер.
            while (CopyNum > 0)
            {
                answer += CopyNum % 10;
                CopyNum /= 10;
            }


            Console.Write("Sum of digits = " + answer);
        }
    }
}
