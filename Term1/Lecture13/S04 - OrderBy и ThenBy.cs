using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Slide04
{
    class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            return LastName + "\t" + Name;
        }
    }

    public static class Program
    {
        public static void Print<T>(this IEnumerable<T> collection)
        {
            foreach (var e in collection)
                Console.WriteLine(e);
        }

        public static void MainX()
        {
            var persons = new List<Person>
            {
                new Person { Name="John", LastName = "Smith" },
                new Person { Name="James", LastName = "Smith" },
                new Person { Name="Bob", LastName="Adams" }
            };

            persons
                .OrderBy(z => z.LastName) //Это сортирует людей по фамилии
                .Print(); 

            persons
                .OrderBy(z => z.Name) //Это сортирует людей по имени
                .Print();

            persons
                .OrderBy(z => z.LastName)
                .OrderBy(z => z.Name) //Это НЕПРАВИЛЬНО! Первая сортировка будет сброшена, а коллекция пересортирована только по имени
                .Print();

            persons
                .OrderBy(z => z.LastName)
                .ThenBy(z => z.Name) //Это правильно. Так мы сортируем людей по фамилии, а людей с одинаковыми фамилиями - по имени
                .Print();



        }
    }
}