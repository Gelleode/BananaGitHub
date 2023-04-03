namespace Numero_10;
public class Program
{
    public static void Main()
    {
        double number = EnterDouble();

        Console.WriteLine($"{FunctionF(number)}");
    }
    private static double EnterDouble()
    {
        double number;
        while (true)
        {
            string? input = Console.ReadLine();
            bool parse = double.TryParse(input, out number);
            if (parse)
                break;
        }
        return number;
    }

    private static double FunctionF(double number) => (6 * Math.Sin(number * 2)) - Math.Cos(number * 2);
}