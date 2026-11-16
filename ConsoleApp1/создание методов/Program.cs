using System;

public class Calculator
{   
    public int Add(int a, int b)
    {
        return a + b;
    }
    private double Div(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Деление на ноль ЗАПРЕЩЕНО!!!");
            return 0;
        }
        return (double) a / b;
    }
    public double CalculDiv(int a, int b)
    {
        return Div(a, b);
    }
}

class Program
{
    static void Main()
    {
        Calculator calc1 = new Calculator();
        Console.WriteLine("Сумма: " + calc1.Add(10, 5));                  
        Console.WriteLine("Частное: " + calc1.CalculDiv(10, 4));         
    }
}