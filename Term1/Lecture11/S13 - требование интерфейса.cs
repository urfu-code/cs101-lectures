using System;

namespace Slide13
{
    public class MyList<T> 
        where T : IComparable //так я требую, чтобы элементы массива реализовывали интерфейс IComparable, т.е. чтобы из можно было сравнивать
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
        public void Sort() //теперь я могу их сортировать
        {
            for (int i = 0; i < Count; i++)
                for (int j = 0; j < Count - 1; j++)
                    if (array[j].CompareTo(array[j + 1]) < 0) //поскольку я потребовал, чтобы T реализовывал IComparable,
                    //я могу вызывать метод CompareTo, определенный в этом интерфейсе
                    {
                        var t = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = t;
                    }
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

            //foreach (var e in list) Console.WriteLine(e);//ошибка компиляции. С чего бы к list можно применять foreach?

            //var list1=new MyList<int[]>(); //ошибка компиляции - массивы нельзя сравнивать!
        }
    }
}