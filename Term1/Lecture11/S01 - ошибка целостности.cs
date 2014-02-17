using System;

namespace Slide01
{

    public class Employee
    {
        public double Salary;
    }


    public class Program
    {
        public static void MainЧ()
        {
            var emp = new Employee();
            emp.Salary = -1000;
            // Проблема: никто не может помешать нам установить отрицательную зарплату =(
            // Это называется ошибкой целостности: когда мы нарушаем некие договоренности о том, какие значения могут быть
            // у полей класса
       }
    }
}