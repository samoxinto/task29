using System;

namespace Task29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var items = new string[8];

            Console.WriteLine("Введите 5 чисел:");

            items[0] = Console.ReadLine();
            items[1] = Console.ReadLine();
            items[2] = Console.ReadLine();
            items[3] = Console.ReadLine();
            items[4] = Console.ReadLine();

            for (int i = 0; i < 5; i++)
                Console.Write(items[i] + " ");

            Console.WriteLine("\nВведите еще 3 числа:");

            items[5] = Console.ReadLine();
            items[6] = Console.ReadLine();
            items[7] = Console.ReadLine();

            for (int i = 5; i < 8; i++)
                Console.Write(items[i] + " ");

            Console.ReadLine();
        }
    }
}
