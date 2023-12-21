using System;

class Calculator //класс калькулятор 
{
    public static int Add(int number1, int number2)// метод для плюса
    {
        return number1 + number2;// делает операцию и возвращает результат
    }
    public static int Subtract(int number1, int number2)// метод для минуса
    {
        return number1 - number2;
    }
    public static int Multiply(int number1, int number2)//метод для умножения
    {
        return number1 * number2;
    }
    public static int Divide(int number1, int number2)// метод для деления
    {
        return number1 / number2;
    }

    static void Main()
    {
        try
        {
            Console.WriteLine("Введите первое число");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выведите второе число");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знак который хотите использовать(+,-,*,/)");
            string? znak = Console.ReadLine();

            switch (znak)// с помощью свича проверяем что пользователь ввел
            {
                case "+":
                    Console.WriteLine($"Результат: {Calculator.Add(number1, number2)}");
                    break;
                case "-":
                    Console.WriteLine($"Результат: {Calculator.Subtract(number1, number2)}");
                    break;
                case "*":
                    Console.WriteLine($"Результат: {Calculator.Multiply(number1, number2)}");
                    break;
                case "/":
                    Console.WriteLine($"Результат: {Calculator.Divide(number1, number2)}");
                    break;
                default:
                    Console.WriteLine("Неверная операция.");
                    break;
            }
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Не дели пожалуйста на ноль");
        }
        catch (FormatException)
        {
            Console.WriteLine("Нужно ввести цифру или арифметический символ");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Результат операции слишком большой для данного типа данных");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Произошла непредвиденная ошибка: " + ex.Message);
        }
    }
}