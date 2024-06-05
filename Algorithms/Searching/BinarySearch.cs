namespace Algorithms
{
    public static class BinarySearch
    {
        public static void Run(int[] intArray,int intKeyToSearch)
        {
            int[] input=intArray;
            int key=intKeyToSearch;
            int low=0;
            int high=intArray.Length-1;
            int mid;
            while (low<=high)
            {
                mid=(low+high)/2;
                Console.WriteLine("Mid index: "+mid);
                if (input[mid]==key) 
                {
                    Console.WriteLine("The key is at index :"+mid);
                    return;
                }
                else if (key<input[mid])
                {
                    Console.WriteLine("Key is in left half");
                    high=mid-1;
                }
                else if (key>input[mid])
                {
                    Console.WriteLine("Key is in right half");
                    low=mid+1;
                }
            }
            Console.WriteLine("Key not found in given array!");
        }
    }
}