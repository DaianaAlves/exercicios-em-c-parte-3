sing System;

public class Program
{
    public static void Main()
    {
        Double a, b, r;
        Console.WriteLine("Em que ano você esta?");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Em que ano você nasceu?");
        b = Convert.ToDouble(Console.ReadLine());
        r = a - b;
        Console.WriteLine("Você tem " + r + "anos");


    }
}
