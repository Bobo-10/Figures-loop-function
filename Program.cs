using System;

namespace MyFirstRepo
{
    class Program
    {
        static void Main(string[] args)
            
            //перевернутий трикутник
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
        
        //max значення
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
        //ялинка красива
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

        
    }
}  

