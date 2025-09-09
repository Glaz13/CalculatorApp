using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Калькулятор");
        Console.WriteLine("Доступные операции: +, -, *, /");

        Console.Write("Введите первое число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите операцию (+, -, *, /): ");
        string operation = Console.ReadLine();

        Console.Write("Введите второе число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;

        if (operation == "+")
        {
            result = num1 + num2;
        }
        else if (operation == "-")
        {
            result = num1 - num2;
        }
        else if (operation == "*")
        {
            result = num1 * num2;
        }
        else if (operation == "/")
        {
            if (num2 != 0)
                result = num1 / num2;
            else
                Console.WriteLine("Ошибка: деление на ноль!");
        }
        else
        {
            Console.WriteLine("Неизвестная операция!");
            return;
        }

        Console.WriteLine($"Результат: {num1} {operation} {num2} = {result}");
    }
}