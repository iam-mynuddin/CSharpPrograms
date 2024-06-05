static class IsPrime
{
    public static string IsPrimeNumber(int inputNum)
    {
        if(inputNum<0) return "This is a negtive number";
        if(inputNum==0) return "This is 0";
        if(inputNum==1) return "This is not a prime number";
        if(inputNum==2) return inputNum+" This is a prime number";
        
        for(int i=2;i<Math.Sqrt(inputNum);i++)
        {
            if(inputNum%i==0) return inputNum+" This is not a prime because is divisible by "+i;
        }
        return inputNum+" This is a prime number";
    }
}