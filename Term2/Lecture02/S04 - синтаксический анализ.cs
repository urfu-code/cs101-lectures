using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2
{
    class S04
    {
        public static void MainX()
        {
            var l = Labirynth.CreateLabirynth();
            var str = "([{()[][]{}}])";
            var stack = new Stack<char>();
            var dict = new Dictionary<char, char>
            {
                { '}' , '{' },
                { ')' , '(' },
                { ']' , '[' }
            };
            foreach (var e in str)
            {
                if (dict.Values.Contains(e))
                    stack.Push(e);
                else if (dict.Keys.Contains(e))
                {
                    if (dict[e] != stack.Pop())
                        throw new Exception("");
                }
            }
        }
    }
}
