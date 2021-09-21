using System;

namespace Number_Of_Even_And_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            uint evenNumbersCount, oddNumbersCount = evenNumbersCount = 0;
            Console.WriteLine("Введите число с которого нужно начать отсчёт:");
            int currentValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число на котором нужно завершить отсчёт:");
            uint maxValue = uint.Parse(Console.ReadLine());
            int evenNumbersSum, oddNumbersSum = evenNumbersSum = 0;
            while (currentValue <= maxValue)
            {
                if (currentValue % 2 == 0)
                {
                    evenNumbersCount++;
                    evenNumbersSum += currentValue;
                }
                else
                {
                    oddNumbersCount++;
                    oddNumbersSum += currentValue;
                }
                currentValue++;
            }
            Console.WriteLine("Количество четных чисел в диапазоне = " + evenNumbersCount);
            Console.WriteLine("Количество нечетных чисел в диапазоне = " + oddNumbersCount);
            Console.WriteLine("Сумма четных чисел в диапазоне = " + evenNumbersSum);
            Console.WriteLine("Сумма нечетных чисел в диапазоне = " + oddNumbersSum);
            Console.ReadLine();
        }
    }
}
