using System;
namespace Programs
{

    public static class Factorial
    {
        public static void Run(int intInput)
        {
            double result=1;
            for(int i=2;i<=intInput;i++)
            {
                result*=i;
            }
            Console.WriteLine("Factorial of "+intInput+" is "+result);
        }
    }

}