namespace Collections
{
    public static class ArrayExample
    {
        public static void Run()
        {
            int[] intArr=[1,2,4,5];
            intArr.Append(9);//will not work 
            string[] strArry= { "jji","jsj"};
            strArry.Append("Hi");//will not work
            string[][] twoDimArr={["HI","Bi"],["Hello","World"]};


            
            // MyPrinter.Print(twoDimArr);
            // MyPrinter.PrintSingle(intArr.Count());
            // MyPrinter.Print(unknown);
            // MyPrinter.PrintSingle(unknown);
            //  MyPrinter.Print(intArr);
            //MyPrinter.Print(strArry);
            // MyPrinter.PrintSingle(intArr);
        }
    }
}