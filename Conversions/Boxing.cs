namespace Conversions
{
    public static class Boxing
    {
        public static void Run()
        {
            int i = 123;
            object obj = i; // Boxing
            // int i = 42;
            // int* p = &i; 
        
            Console.WriteLine($"Value of variable i: {i}");
            Console.WriteLine($"Value of object obj: {obj}"); 
        }
    }
}