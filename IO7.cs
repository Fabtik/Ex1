﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class IO7
    {
        public static void main()
        {
            int Num = 0, answer;

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

            answer = (Num / 10) % 10;

            Console.Write("There are " + answer + " tens in your number");
        }
    }
}
