public class Program
{
    public static void Main()
    {
        double a, b, r;
        Console.Write("Digite o valor da base:");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite a alteura:");
        b = Convert.ToDouble(Console.ReadLine());
        r = a * b;
        Console.WriteLine("A area do retangulo é" + r)

    }
}
