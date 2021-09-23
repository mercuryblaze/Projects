using System;

namespace Actions_With_Arrays__1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int[] myArray = new int[int.Parse(Console.ReadLine())];

            Console.WriteLine("\nЗаполните массив целыми числами\n");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Введите элемент массива под индексом {i}: ");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nЧисла, содержащиеся в массиве:");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            Console.WriteLine("\nЧисла, содержащиеся в массиве в обратном порядке:");
            for (int i = myArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(myArray[i]);
            }

            int arrayEvenSum = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0) arrayEvenSum += myArray[i];
            }
            Console.WriteLine("\nСумма чётных чисел в массиве = " + arrayEvenSum);

            int minInArray = myArray[0];
            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] < minInArray) minInArray = myArray[i];
            }
            Console.WriteLine("\nМинимальный элемент массива = " + minInArray);
        }
    }
}
