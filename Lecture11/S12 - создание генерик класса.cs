using System;

namespace Slide12
{
    public class MyList<T> //когда мы написали T в фигурных скобках, оно стало внутри класса таким же полноправным типом, как int или string
                           //T называется генерик-параметром
                           //Генерик параметры принято называть с буквы T: T, TKey, TValue и т.д.
    {
        public T[] array;         // здесь мы объявили массив элементов типа T, поскольку T - теперь название типа
        public int Count=0;
        public void Add(T value) //а здесь мы передали значение типа T в метод
        {
            if (array == null) array = new T[10];
            else if (Count == array.Length)
            {
                // Разумеется, настоящий List<int> работает не так!
                var newArray = new T[array.Length * 2];
                array.CopyTo(newArray, 0);
                array = newArray;
            }
            array[Count] = value;
            Count++;
        }
    }

    public class Program
    {
        public static void MainX()
        {
            var list = new MyList<int>(); //здесь мы сообщаем, что под T подразумеваем (для данного объекта) int
            list.Add(10);
            list.Add(20);
            //list.Add("abc");//ошибка компиляции, int - это не string!
        }
    }
}