using System;

public class Program
{
    public static void Main()
    {
        Double a, b, c, d, media;
        Console.WriteLine("Digite a primeira nota:");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a segunda nota:");
        b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a terceira nota:");
        c = Convert.ToDouble(Console.ReadLine());
        d = a + b + c;
        media = d / 3;
        Console.WriteLine("Sua media é:" + media);


    }
}

