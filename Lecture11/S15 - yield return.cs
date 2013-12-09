using System;
using System.Collections.Generic;

namespace Slide15
{
    public class MyList<T> : IEnumerable<T> //означает, что MyList<T> - перечислимый тип, по нему можно пробежать foreach, последовательно 
        //вытаскивая элементы типа T
        where T : IComparable
    {
        public T[] array;
        public int Count = 0;
        public void Add(T value)
        {
            if (array == null) array = new T[10];
            else if (Count == array.Length)
            {
                var newArray = new T[array.Length * 2];
                array.CopyTo(newArray, 0);
                array = newArray;
            }
            array[Count] = value;
            Count++;
        }
        public void Sort()
        {
            for (int i = 0; i < Count; i++)
                for (int j = 0; j < Count - 1; j++)
                    if (array[j].CompareTo(array[j + 1]) < 0)
                    {
                        var t = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = t;
                    }
        }

        //Этот метод должен возвращать перечислитель
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
                yield return array[i];
        }

        //Это артефакт. Просто переписывайте в свои коды:
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }


    public class Program
    {
        public static void MainX()
        {
            var list = new MyList<int>();
            list.Add(10);
            list.Add(20);
            list.Sort();

            foreach (var e in list) //Теперь можно пользоваться foreach. Пройдите по коду дебаггером!
                Console.WriteLine(e);
        }
    }
}