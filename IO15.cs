using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Ex1
{
    class IO15
    {
        public static void main()
        {
            int Ahours = 0, Aminutes = 0, Aseconds = 0, Bhours = 0, Bminutes = 0, Bseconds = 0;

            int[] str = new int[2];
            try
            {
                str = Console.ReadLine().Split().Select(int.Parse).ToArray();
                Ahours = str[0];
                Aminutes = str[1];
                Aseconds = str[2];
                str = Console.ReadLine().Split().Select(int.Parse).ToArray();
                Bhours = str[0];
                Bminutes = str[1];
                Bseconds = str[2];
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            int Scount = 0;
            while(Bhours > Ahours)
            {
                Scount += 3600;
                Bhours--;
            }
            while(Bminutes > Aminutes)
            {
                Scount += 60;
                Bminutes--;
            }
            while(Bseconds > Aseconds)
            {
                Scount++;
                Bseconds--;
            }

            Console.WriteLine(Scount);
        }
    }
  
}
