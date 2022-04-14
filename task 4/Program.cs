using System;

namespace task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Eded daxil edin:");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a <= 9)
            {
                Console.WriteLine("1-reqemli");
            }
            else if (a >= 10 && a < 100)
            {
                Console.WriteLine("2-reqemli");
            }
            else if (a >= 100 && a < 1000)
            {
                Console.WriteLine("3-reqemli");
            }
            else if (a >= 1000 && a < 10000)
            {
                Console.WriteLine("4-reqemli");
            }
            else if (a >= 10000 && a < 100000)
            {
                Console.WriteLine("5-reqemli");
            }
        }
    }
}
