using System;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double firstNumber, secondNumber;
                string operation;
                try
                {
                    Console.WriteLine("Введите первое число:");
                    firstNumber = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число:");
                    secondNumber = double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Ошибка. Введите только число.");
                    Console.ReadLine();
                    continue; // после этого ключевого слова код ниже выполняться не будет, а мы попадём в начало нашего цикла while
                }
                Console.WriteLine("Выберите арифметическую операцию: '+', '-', '*', '/'.");
                operation = Console.ReadLine();
                switch (operation)
                {
                    case "+":
                        Console.WriteLine("Сумма чисел = " + (firstNumber + secondNumber));
                        break;
                    case "-":
                        Console.WriteLine("Разность чисел = " + (firstNumber - secondNumber));
                        break;
                    case "*":
                        Console.WriteLine("Произведение чисел = " + firstNumber * secondNumber);
                        break;
                    case "/":
                        if (secondNumber == 0) Console.WriteLine("На ноль делить нельзя!");
                        else Console.WriteLine("Частное чисел = " + firstNumber / secondNumber);
                        break;
                    default:
                        Console.WriteLine("Этот символ не предусмотрен логикой программы");
                        break;
                }
                // Способ №2
                if (operation == "+") Console.WriteLine("Сумма чисел = " + (firstNumber + secondNumber));
                else if (operation == "-") Console.WriteLine("Разность чисел = " + (firstNumber - secondNumber));
                else if (operation == "*") Console.WriteLine("Произведение чисел = " + firstNumber * secondNumber);
                else if (operation == "/")
                {
                    if (secondNumber == 0) Console.WriteLine("На ноль делить нельзя!");
                    else Console.WriteLine("Частное чисел = " + firstNumber / secondNumber);
                }
                else Console.WriteLine("Этот символ не предусмотрен логикой программы");
                Console.ReadKey();
            }
        }
    }
}
