using System;
using System.Collections.Generic;

namespace Sweeft_Digital_4
{
 
    internal class Program
    {
        static bool IsProperly(string sequence)
        {
            Stack<char> stack = new Stack<char>();
            foreach (var s in sequence)
            {
                if (s == '(')
                    stack.Push(s);
                else
                {
                    if (stack.Count != 0)
                        stack.Pop();
                    else
                        return false;
                }

            }

            if (stack.Count == 0)
                return true;

            return false;

        }
        static void Main(string[] args)
        {
            var result = IsProperly("()()()");
            Console.WriteLine(result);
        }
    }
    }


