using System;
namespace MyFirstRepo
{
    class Program
    {
        static void Main(string[] args)
            
            //ПЕРЕВЕРНУТИЙ ТРИКУТНИК
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
        //МАКСИМАЛЬНЕ ЗНАЧЕННЯ
        {
            int a = 5;
            int b = 6;
            int c = 8;
            int d = 15;
            int max = a;
            if (max<b)
            {
                max = b;              
                if (max < c)
                    max = c;
             }
            if (max < d)
                max = d;
                    {
                Console.WriteLine(max);
                    }
             }
        //ЯЛИНКА КРАСИВА
            Console.ReadLine();

            Console.WriteLine("Please enter number of triangles of your tree: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    string branch = new String('*', j);
                    Console.WriteLine(branch.PadLeft(n + 3) + "*" + branch);
                }
            }
        //КВАДРАТ
            int y = 0;
            int a = 5;
            while (y < a)
            {
               int x = 0;
               while (x < a)
               {
                   Console.Write("*");
                   x += 1;
               }
               y++;
               Console.WriteLine();
            }
        
        //ТРИКУТНИК   
            int y = 0;
            int x = 7;
            while (y < x)
            {
                int z = 0;
                while (z < y)
                {
                    Console.Write("*");
                    z += 1;
                }
                y++;
                Console.WriteLine("#");
            }
        //ПРЯМОКУТНИК
            int y = 0;
            int a = 3;
            while (y < a)
            {
                int x = -6;
                while (x < a)
                {
                    Console.Write("*");
                    x += 1;
                }
                y++;
                Console.WriteLine();
            }
        
        //ПИФАГОР
            {
                for (int i = 1; i <= 7; i++)
                {
                    for (int j = 1; j <= 7; j++)
                    {
                        int k = i * j;
                        Console.Write("  " + k);
                    }
                    Console.WriteLine(" ");
                }
                Console.ReadLine();
            }
        
    }
}  

