using System;

class Money
{
    public int Grivna { get; set; }
    public int Coin { get; set; }

    public Money(int _grivna, int _coin)
    {
        Grivna = _grivna;
        Coin = _coin;
    }

    public void PrintMoney()
    {
        Console.WriteLine($"Целая часть {Grivna}  {Coin} копеек");
    }
}

class Product
{
    public Money Money { get; set; }

    public void MinusMoney(int minusMoney, int minusCoin)
    {
        Money.Grivna -= minusMoney;

        if (Money.Coin < minusCoin)
        {
            // Если копеек не хватает для вычета, уменьшаем целую часть
            Money.Grivna -= 1;
            // Коррекция копеек
            Money.Coin = 100 - (minusCoin - Money.Coin);
        }
        else
        {
            Money.Coin -= minusCoin;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Money money = new Money(100, 75);
        money.PrintMoney();

        Product product = new Product();
        product.Money = new Money(50, 30);
        Console.WriteLine($"Остаток до вычета: {product.Money.Grivna} {product.Money.Coin}");
        product.MinusMoney(20, 20);
        Console.WriteLine($"Остаток после вычета: {product.Money.Grivna} {product.Money.Coin}");
    }
}
