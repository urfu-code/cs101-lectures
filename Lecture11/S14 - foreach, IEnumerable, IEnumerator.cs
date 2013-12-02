using System;
using System.Collections.Generic;

namespace Slide14
{
    public class MyList<T> : IEnumerable<T> //означает, что MyList<T> - перечислимый тип, по нему можно пробежать foreach, последовательно 
                                            //вытаскивая элементы типа T
        where T : IComparable 
    {
        public T[] array;         
        public int Count=0;
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
            return new MyListEnumerator<T>(this); //this - это ЭТОТ объект, т.е. объект, метод которого выполняется в настоящий момент
        }

        //Это артефакт. Просто переписывайте в свои коды:
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    
    public class MyListEnumerator<T> : IEnumerator<T> //Это класс - перечислитель. Он умеет переползать на следующий элемент коллекции
                                                      //и возвращать текущий элемент
        where T : IComparable 
    {
        public MyListEnumerator(MyList<T> list)
        {
            myList = list;
        }
        MyList<T> myList; //Это - экземпляр коллекции, по которой я буду ползти
        int pointer = -1; //Это - указатель на текущий элемент коллекции

        public T Current
        {
            get { return myList.array[pointer]; }
        }

        public bool MoveNext()
        {
            pointer++; //переползаем на следующий элемент
            return pointer < myList.Count; //возвращает true, если еще есть, куда ползти
        }

        #region Это артефакты

        public void Dispose()
        {
            
        }

        object System.Collections.IEnumerator.Current
        {
            get { return Current; }
        }



        public void Reset()
        {

        }
        #endregion
    }


    public class Program
    {
        public static void Main()
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