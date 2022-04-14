using System;

namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Eded daxil edin= ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 3 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
