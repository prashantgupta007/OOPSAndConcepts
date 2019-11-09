using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPSAndCore
{
    public class Amazon
    {
        public static void Main1()
        {
            //var result = hasBalancedBrackets("(h[e{lo}!]~)()()()(");


        }

        public static int findMinNumSteps(int[,] maze, int rows, int columns, int exitRow, int exitCol)
        {
            
            return 1;
        }

        private static readonly char[] OpenParentheses = { '(', '{', '[', '<' };
        private static readonly char[] CloseParentheses = { ')', '}', ']', '>' };

        public static bool hasBalancedBrackets1(string input)
        {
            // Indices of the currently open parentheses:
            Stack<int> parentheses = new Stack<int>();

            foreach (char chr in input)
            {
                int index;

                // Check if the 'chr' is an open parenthesis, and get its index:
                if ((index = Array.IndexOf(OpenParentheses, chr)) != -1)
                {
                    parentheses.Push(index);  // Add index to stach
                }
                // Check if the 'chr' is a close parenthesis, and get its index:
                else if ((index = Array.IndexOf(CloseParentheses, chr)) != -1)
                {
                    // Return 'false' if the stack is empty or if the currently
                    // open parenthesis is not paired with the 'chr':
                    if (parentheses.Count == 0 || parentheses.Pop() != index)
                        return false;
                }
            }
            // Return 'true' if there is no open parentheses, and 'false' - otherwise:
            return parentheses.Count == 0;
        }

        private static int hasBalancedBrackets2(string input)
        {
            var stack = new Stack<char>();
            // dictionary of matching starting and ending pairs
            var allowedChars = new Dictionary<char, char>() { { '(', ')' }, { '{', '}' }, { '[', ']' }, { '<', '>' } };

            var wellFormated = true;
            foreach (var chr in input)
            {
                if (allowedChars.ContainsKey(chr))
                {
                    // if starting char then push on stack
                    stack.Push(chr);
                }
                // ContainsValue is linear but with a small number is faster than creating another object
                else if (allowedChars.ContainsValue(chr))
                {
                    // make sure something to pop if not then know it's not well formated
                    wellFormated = stack.Any();
                    if (wellFormated)
                    {
                        // hit ending char grab previous starting char
                        var startingChar = stack.Pop();
                        // check it is in the dictionary
                        wellFormated = allowedChars.Contains(new KeyValuePair<char, char>(startingChar, chr));
                    }
                    // if not wellformated exit loop no need to continue
                    if (!wellFormated)
                    {
                        break;
                    }
                }
            }
            return wellFormated == false ? 0 : 1;
        }

        private static readonly char[] _leftBrackets = new char[] { '(', '{', '[', '<' };
        private static readonly char[] _rightBrackets = new char[] { ')', '}', ']', '>' };

        public static bool hasBalancedBrackets3(string input)
        {
            int count = 0;
            foreach (var character in input.ToCharArray())
            {
                if (_leftBrackets.Contains(character))
                    count++;
                if (_rightBrackets.Contains(character))
                    count--;
            }
            return count == 0;
        }

        public static int hasBalancedBrackets(string input)
        {
            //Use the closer rather than opener as the key.
            // This will give better lookups when we pop the stack
            var pairs = new Dictionary<char, char>() { { '}', '{' }, { ']', '[' }, { ')', '(' }, { '>', '<' } };
            var history = new Stack<char>();

            foreach (char c in input)
            {
                if (pairs.ContainsValue(c)) history.Push(c);
                if (pairs.ContainsKey(c) && (history.Count == 0 || history.Pop() != pairs[c]))
                    return 0;
            }
            return (history.Count == 0 ? 1 : 0);
        }

        //Find Max depth of JSON Object
        public static int minMovement(string input1)
        {
            var result = 0;
            char[] openingParanthesis = { '[', '{' };
            //char[] closingParanthesis = {']', '}'};

            if (input1.Length == 0)
            {
                return 0;
            }

            foreach (char c in input1)
            {
                var index = Array.IndexOf(openingParanthesis, c);

                if (index != -1)
                {
                    result++;
                }
            }

            return result;
        }
    }
}

/*

 

*/
