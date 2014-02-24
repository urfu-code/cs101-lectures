using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2
{
    class MyLinkedStack<T> : IEnumerable<T>
    {
        class StackItem<T>
        {
            public T value;
            public StackItem<T> next;
        }

        StackItem<T> top;

        public void Push(T arg)
        {
            var newitem = new StackItem<T> { value = arg, next = top };
            top = newitem;
        }

        public T Pop()
        {
            if (top == null) throw new Exception("");
            var result = top.value;
            top = top.next;
            return result;
        }


        public IEnumerator<T> GetEnumerator()
        {
            var item = top;
            while (item != null)
            {
                yield return item.value;
                item = item.next;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
