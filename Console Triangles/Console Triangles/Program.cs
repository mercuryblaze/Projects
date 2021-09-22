using System;

namespace Console_Triangles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите высоту треугольника:");
            int height = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("|");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < height; i++)
            {
                for (int j = height; j > i; j--)
                {
                    Console.Write("|");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < height; i++)
            {
                for (int j = height; j > i + 1; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("|");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = height; j > i; j--)
                {
                    Console.Write("|");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
