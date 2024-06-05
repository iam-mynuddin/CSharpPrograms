namespace Conversions
{
    public static class UnBoxing
    {
        public static void Run()
        {
            object obj = 123;
            int i = (int)obj; 
            
            Console.WriteLine($"Value of variable i: {i}");
            Console.WriteLine($"Value of object obj: {obj}"); 
        }
    }
}