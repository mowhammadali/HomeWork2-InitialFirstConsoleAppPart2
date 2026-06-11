namespace Task3;

class Statistics
{
    public void AnalyzeNumbers(int x, ref int y, out int z)
    {
        int sum = x + y;
        z = sum;

        y = y * y;

        Console.WriteLine($"First parameter: {x}");
    }
}