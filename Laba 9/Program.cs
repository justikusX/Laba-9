using System;

public class NumDifference
{
    public double a { get; set; }
    public double b { get; set; }

    public NumDifference(double a, double b)
    {
        this.a = a;
        this.b = b;
    }

    public string GetInfa()
    {
        return $"Поле 1 (a): {a}, Поле 2 (b): {b}";
    }

    public double Difference()
    {
        return (a * a) - (b * b);
    }
}


public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите значение для Поля 1 (a):");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение для Поля 2 (b):");
        double b = Convert.ToDouble(Console.ReadLine());

        NumDifference obj = new NumDifference(a, b);
        Console.WriteLine(obj.GetInfa());
        Console.WriteLine($"Разность квадратов: {obj.Difference()}");
    }
}