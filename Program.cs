using System;
namespace MyFirstRepo
{
    class Program
    {
        static void Main(string[] args)
            
                          // ФІГУРКИ В КОНСОЛІ З ДОПОМОГОЮ ЦИКЛІВ
            
        //ПРОСТИЙ ТРИКУТНИК
        {
           Console.WriteLine("Enter height for your triangle:");
           int height = int.Parse(Console.ReadLine());
           for (int i = 0; i < height; i++)
           {
               for (int j = 0; j <= i; j++)
               {
                   Console.Write("*");
               }
               Console.WriteLine();
           }
           Console.ReadLine();
        }
        //ПЕРЕВЕРНУТИЙ ТРИКУТНИК
        {
           Console.Write("Enter height for your triengle:");
           int height = int.Parse(Console.ReadLine());
           for (int i = 0; i < height; i++)
           {
               for (int j = height; j > i; j--)
               {
                   Console.Write("*");
               }
               Console.WriteLine();
           }
           Console.ReadLine();
        }
        //ЗЕРКАЛЬНИЙ ТРИКУТНИК
        {
           Console.WriteLine("Enter height for your triangle:");
           int height = int.Parse(Console.ReadLine());
           for (int i = 0; i < height; i++)
           {
               for (int j = height; j > i; j--)
               {
                   Console.Write(" ");
               }
               for (int j = 0; j <= i; j++)
               {
                   Console.Write("*");
               }
               Console.WriteLine();
           }
           Console.ReadLine();
        }
        //ЗЕРКАЛЬНИЙ ТРИКУТНИК 2
        {
           Console.Write("Enter height for your triengle:");
           int height = int.Parse(Console.ReadLine());
           for (int i = 0; i < height; i++)
           {
               for(int j = 0; j <= i; j++)
               {
               Console.Write(" ");
           }
           for (int j = height; j > i; j--)
               {
                   Console.Write("*");
               }
               Console.WriteLine();
           }
           Console.ReadLine();
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
        
        
        
    }
}  

