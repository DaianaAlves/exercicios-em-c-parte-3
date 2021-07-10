using System;

public class Program
{
    public static void Main()
    {
        Double a, b, s, sub, div, multi;
        Console.WriteLine("Digite o primeiro numero:");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o segundo numero:");
        b = Convert.ToDouble(Console.ReadLine());
        s = a + b;
        Console.WriteLine("A soma de a e b é:" + s);
        sub = a - b;
        Console.WriteLine("A subtração de a e b é:" + sub);
        div = a * b;
        Console.WriteLine("A divisão de a e b é:" + div);
        multi = a / b;
        Console.WriteLine("A multiplicação de a e b é :" + multi);
    }
}
