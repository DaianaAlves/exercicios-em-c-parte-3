public class Program
{
    public static void Main()
    {
        double, n1, n2, n3, r;
        Console.WriteLine("Digite a primeira nota :");
        n1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a segunda nota:");
        n2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a terceira nota:");
        n3 = Convert.ToDouble(Console.ReadLine());
        r = ((n1 * 2) + (n2 * 3) + (n3 * 5)) / 10;

        Console.ReadKey();

    }
}
