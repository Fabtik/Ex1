using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Завдання для вирiшення на тему ввiд вивiд");
            Console.WriteLine("Select");
            int n = 1;
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            switch (n)
            {
                case 1:
                    IO1.main();
                    break;
                case 2:
                    IO2.main();
                    break;
                case 3:
                    IO3.main();
                    break;
                case 4:
                    IO4.main();
                    break;
                case 5:
                    IO5.main();
                    break;
                case 6:
                    IO6.main();
                    break;
                case 7:
                    IO7.main();
                    break;
                case 8:
                    IO8.main();
                    break;
                case 9:
                    IO9.main();
                    break;
                case 10:
                    IO10.main();
                    break;
                case 11:
                    IO11.main();
                    break;
                case 12:
                    IO12.main();
                    break;
                case 13:
                    IO13.main();
                    break;
                case 14:
                    IO14.main();
                    break;
                case 15:
                    IO15.main();
                    break;
                case 16:
                    IO16.main();
                    break;
                case 17:
                    IO17.main();
                    break;
                case 18:
                    IO18.main();
                    break;
                case 19:
                    IO19.main();
                    break;
                case 20:
                    IO20.main();
                    break;
                case 21:
                    IO21.main();
                    break;
                default:
                    Console.WriteLine("Out of Range");
                    break;
            }

        }
    }
}
