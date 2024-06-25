using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programs
{
    public static class UniqueChars
    {
        public static void Run()
        {
            string strInput="Hello World";

            HashSet<char> charSet=new();

            foreach(char c in strInput)
            {
                charSet.Add(c);
            }

            foreach(char c in charSet)
            {
                Console.WriteLine(c);
            }

        }
    }
}