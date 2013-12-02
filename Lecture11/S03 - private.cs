using System;

namespace Slide03
{

    class Employee
    {
        private double Salary; //ключевое слово private означает, что область видимости переменной ограничена методами класса

        public void SetSalary(double salary)
        {
            if (salary < 0) throw new ArgumentException(""); //так мы сигнализируем об ошибке
            Salary = salary;
        }
    }


    public class Program
    {
        public static void MainX()
        {
            var emp = new Employee();
            emp.SetSalary(-1000); //этот метод вызовет runtime exception.
            //emp.Salary = -1000; //обращаться к Salary можно только изнутри класса Employee. 
            //Console.WriteLine(emp.Salary); //так делать тоже нельзя. Как же получить это значение?
               

        }
    }
}