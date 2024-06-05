namespace Collections
{

    public static class MyPrinter
    {
        public static void Print<T>(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }

        public static void PrintObjList(List<Object> objList)
        {
            foreach(var obj in objList)
            {
                Console.WriteLine(obj.GetType());
            }
        }
        public static void PrintWithLineNumber<T>(IEnumerable<T> collection)
        {
            int i=0;
            foreach(var item in collection)
            {
                if(item!=null)
                Console.WriteLine("Line "+i.ToString()+": "+item.ToString());
                else
                Console.WriteLine("Line "+i.ToString()+": "+item);
                i++;
            }
        }
        public static void PrintSingle<T>(T value)
        {
            Console.WriteLine(value);
        }
    }
}