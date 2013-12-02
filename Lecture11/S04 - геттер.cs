using System;

namespace Slide04
{

    class Employee
    {
        private double Salary; //ключевое слово private означает, что область видимости переменной ограничена методами класса

        public void SetSalary(double salary)
        {
            if (salary < 0) throw new ArgumentException(""); //так мы сигнализируем об ошибке
            Salary = salary;
        }

        public double GetSalary()
        {
            return Salary;
        }
    }


    public class Program
    {
        public static void MainX()
        {
            var emp = new Employee();
            emp.SetSalary(1000); //этот метод вызовет runtime exception.
            Console.WriteLine(emp.GetSalary());
            emp.SetSalary(emp.GetSalary() * 2); //выглядит не очень. Хотелось бы emp.Salary*=2;

        }
    }
}