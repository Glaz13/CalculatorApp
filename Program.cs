using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Калькулятор сложения");

        Console.Write("Введите первое число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = num1 + num2;
        Console.WriteLine($"Результат: {num1} + {num2} = {result}");
    }
}