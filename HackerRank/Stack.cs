namespace HackerRank
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class Stack
    {
        public static void Reverse(string input)
        {
            var stack = new Stack<char>();

            foreach (var item in input)
            {
                stack.Push(item);
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
