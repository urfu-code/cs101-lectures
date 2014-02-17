using System;

namespace Slide02
{

    public class Employee
    {
        public double Salary;
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
            emp.Salary = -1000; //но, к сожалению, все еще можно писать так
               

        }
    }
}