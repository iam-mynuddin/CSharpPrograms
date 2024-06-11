using System.Net;

namespace LeetCodeChallenges
{
    public static class Problem20
    {
        public static void Run()
        {
            Console.WriteLine(Solution.IsValid("()"));
        }

        public static class Solution
        {
            public static bool IsValid(string s)
            {
                Stack<char> stack =new();
                foreach(char c in s)
                {
                    if(c=='(') stack.Push(')');
                    else if(c=='[') stack.Push(']');
                    else if(c=='{') stack.Push('}');

                    else if(stack.Count==0||stack.Pop()!=c)
                    {
                        return false;
                    }
                }
                return stack.Count==0;
            }
        }

        public static class MySolution
        {
            public static bool IsValid(string s)
            {
                Dictionary<char,char> charPairs=new();
                charPairs.Add('(',')');
                charPairs.Add('[',']');
                charPairs.Add('{','}');

                if (s == null || s.Length == 1)
                {
                    return false;
                }
                Stack<char> stack = new();
                foreach (char c in s)
                {
                    if (charPairs.ContainsKey(c))
                    {
                        stack.Push(c);
                    }
                    else
                    {
                        if(stack.Count<=0) return false;
                        char pop=stack.Pop();
                        char value;
                        if(charPairs.TryGetValue(pop,out value))
                        {
                            if(c==value) continue;
                            else return false;
                        } 
                    }
                }
                if(stack.Count==0) return true;
                return false;
            }
        }
    }
}