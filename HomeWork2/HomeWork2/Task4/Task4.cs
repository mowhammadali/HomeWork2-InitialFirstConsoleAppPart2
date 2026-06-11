namespace Task4;

class ArrayAnalyzer
{
    public void AnalyzeArray(int[] numbersArray, ref int max, out double average)
    {
        if (numbersArray.Length == 0)
        {
            average = 0.0;
            max = 0;
        }
        else if (numbersArray.Length == 1)
        {
            max = numbersArray[0];
            average = numbersArray[0];
        }
        else
        {
            int tempMax = 0;
            int sum = 0;

            for (int i = 0; i < numbersArray.Length; i++)
            {
                sum += numbersArray[i];
                if (numbersArray[i] > tempMax)
                {
                    tempMax = numbersArray[i];
                }
            }

            max = tempMax;
            average = (double)sum / numbersArray.Length;
        }
    }
}