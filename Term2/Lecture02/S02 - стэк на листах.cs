using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2
{
    class MyStack<T> : IEnumerable<T>
    {
        static List<T> list = new List<T>();

        public void Push(T arg)
        {
            list.Add(arg);
        }

        public T Pop()
        {
            if (list.Count == 0)
                throw new Exception();
            var result = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return result;
        }


        public IEnumerator<T> GetEnumerator()
        {
            foreach (var e in list)
                yield return e;
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class Program
    {
        static void MainX(string[] args)
        {

            var stack = new MyStack<int>();
            stack.Push(2);
            stack.Push(3);

            foreach (var e in stack)
                Console.WriteLine(e);


            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            
        }

    }
}
