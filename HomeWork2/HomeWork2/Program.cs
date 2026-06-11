using Task1;
using Task2;
using Task3;

class Program
{
    static void Main(string[] args)
    {
        // Task 3
        Statistics statistics = new Statistics();

        Console.Write("Enter input1: ");
        string input1 = Console.ReadLine();
        Console.Write("Enter input2: ");
        string input2 = Console.ReadLine();

        if (int.TryParse(input1, out int a) && (int.TryParse(input2, out int b)))
        {
            int c;

            statistics.AnalyzeNumbers(a, ref b, out c);

            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b: {b}");
            Console.WriteLine($"c: {c}");
        }
    }
}