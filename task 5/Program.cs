using System;

namespace task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("birinci eded= ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ikinci eded= ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a % b == 0)
            {
                Console.WriteLine("tam bolunur");
            }
            else
            {
                Console.WriteLine("bolunmur");
            }
        }
    }
}
