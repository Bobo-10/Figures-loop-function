using System;

namespace MyFirstRepo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the height your triangle:");
            int height = int.Parse(Console.ReadLine());
            for (int i = 0; i < height; i++)
            {
                for (int j = height; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}    