using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class IO3
    {
        public static void main()
        {
            float N = 0, K = 0;
            int Answer;
            try
            {
                Console.Write("N = ");
                N = Convert.ToInt32(Console.ReadLine());
                Console.Write("K = ");
                K = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }
            
            Answer = (int)(K / N);
            Console.WriteLine(Answer);
        }
    }
}
