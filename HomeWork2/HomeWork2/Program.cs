using Task1;
using Task2;
using Task3;
using Task4;

class Program
{
    static void Main(string[] args)
    {
        // Task 1
        Student student = new("John" , 25);
        student.Introduce();
        
        
        // Task 2
        BankAccount account = new BankAccount();
        account.Deposit(45.2);
        account.Deposit(55);
        account.Deposit(120);
        account.Withdraw(50);
        account.Withdraw(430);
        account.ShowBalance();
         
        
        // Task 3
        Console.Write("Enter input1: ");
        string input1 = Console.ReadLine();
        Console.Write("Enter input2: ");
        string input2 = Console.ReadLine();

        if (int.TryParse(input1, out int a) && (int.TryParse(input2, out int b)))
        {
            Statistics statistics = new Statistics();

            int c;

            statistics.AnalyzeNumbers(a, ref b, out c);

            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b: {b}");
            Console.WriteLine($"c: {c}");
        }


        // Task 4
        Console.Write("Enter array length: ");
        string arrayLength = Console.ReadLine();

        if (int.TryParse(arrayLength, out int length) && length >= 0)
        {
            int[] numbers = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write($"Enter number{i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            ArrayAnalyzer analyzer = new ArrayAnalyzer();

            int max = 0;
            double average;

            analyzer.AnalyzeArray(numbers, ref max, out average);

            Console.WriteLine($"max: {max}");
            Console.WriteLine($"average: {average}");
        }
    }
}