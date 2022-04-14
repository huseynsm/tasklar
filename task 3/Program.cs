using System;

namespace task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci ededi daxil et= ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ikinci ededi daxil et= ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a + b > 9 && a + b < 100)
            {
                Console.WriteLine("cem ikireqemli ededdir");
            }
            else if (a + b > 99 && a + b < 1000)
            {
                Console.WriteLine("cem ucreqemlidir");
            }
            else
            {
                Console.WriteLine("nezere alinmayib");
            }
        }
    }
}
