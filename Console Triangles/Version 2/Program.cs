using System;

namespace Version_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите высоту треугольника:");
            int height = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(height - i - 1, i + 2);
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("|");
                }
            }
            Console.WriteLine();
        }
    }
}
