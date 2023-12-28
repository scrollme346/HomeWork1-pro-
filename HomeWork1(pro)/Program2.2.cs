using System;

struct Number
{
    private int value;

    public Number(int value)
    {
        this.value = value;
    }

    public void Number1()
    {
        Console.WriteLine($"Ваше число: {value}");
    }
    public void ConvertToBinary()
    {
        string two = Convert.ToString(value, 2);
        Console.WriteLine($"Двоичная система: {two}");
    }

    public void ConvertToOctal()
    {
        string ein = Convert.ToString(value, 8);
        Console.WriteLine($"Восмерочная система: {ein}");
    }

    public void ConvertToHexadecimal()
    {
        string sixteen = Convert.ToString(value, 16);
        Console.WriteLine($"Шестнадцатеричная система: {sixteen}");
    }
}

class Program
{
    static void Main()
    {
        Number Number = new Number(42);

        // Вызов методов для перевода в расзные системы
        Number.Number1();
        Number.ConvertToBinary();
        Number.ConvertToOctal();
        Number.ConvertToHexadecimal();
    }
}
