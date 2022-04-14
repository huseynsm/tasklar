using System;

namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Eded daxil edin= ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 3 == 0 && a % 2 == 0)
            {
                Console.WriteLine("3-e bolunur cutdur");
            }
            else if (a % 3 == 0 && a % 2 != 0)
            {
                Console.WriteLine("3-e bolunur tekdir");
            }
            else
            {
                Console.WriteLine("3-e bolunmur");
            }
        }
    }
}
