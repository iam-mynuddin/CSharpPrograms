public static class PrimeNumber
{
    public static void Run(int intInput)
    {
        string strResult = IsPrimeNumber(intInput);
        Console.WriteLine(strResult);
    }
    public static string IsPrimeNumber(int inputNum)
    {
        if (inputNum < 0) return inputNum + " is a negtive number";
        if (inputNum == 0) return "This is 0";
        if (inputNum == 1) return inputNum + " is not a prime number";
        if (inputNum == 2) return inputNum + " is a prime number";

        for (int i = 2; i < Math.Sqrt(inputNum); i++)
        {
            if (inputNum % i == 0) return inputNum + " is not a prime because is divisible by " + i;
        }
        return inputNum + " is a prime number";
    }
}