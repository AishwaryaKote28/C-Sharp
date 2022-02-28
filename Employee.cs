using System;
using System.Collections.Generic;
using System.Text;

namespace arraysdemo
{

    #region Interface
    //interface IEmployee
    //{
    //    void Showempname();


    //}
    //class EmpSalary : IEmployee
    //{
    //    public void Showempname()
    //    {
    //        Console.WriteLine("Aishwarya Kote");
    //    }
    //    public void Empsalary()
    //    {
    //        Console.WriteLine("10000");
    //    }

    //}
    #endregion
    #region Abstract Class

    //abstract class Person
    //{
    //    public String FirstName;
    //    public String LasttName;
    //    public int Age;
    //    abstract public void ShowDetails();
    //}
    //class Student : Person
    //{
    //    public int RollNo;
    //    public int Fees;
    //    public override void ShowDetails()
    //    {
    //        String Name = this.FirstName + " " + this.LasttName;
    //        Console.WriteLine("Student Name is: {0} ", Name);
    //        Console.WriteLine("Student Age is: {0}", this.Age);
    //        Console.WriteLine("Student RollNo is: {0}", this.RollNo);
    //        Console.WriteLine("Student Fees is: {0}", this.Fees);
    //    }
    //}
    //class Teacher : Person
    //{
    //    public int Salary;
    //    public override void ShowDetails()
    //    {
    //        String Name = this.FirstName + " " + this.LasttName;
    //        Console.WriteLine("Teacher Name is:{0} ", Name);
    //        Console.WriteLine("Teacher Age is:{0} ", this.Age);
    //        Console.WriteLine("Teacher Salary is: {0}", this.Salary);
    //    }
    //}
    #endregion

    #region Overloading
    //class Calculation
    //{
    //    public void Area( int length,int breadth)
    //    {
    //        Console.WriteLine("Area of Rectangle : "+ length * breadth);
    //    }
    //    public void Area(int radius)
    //    {
    //        Console.WriteLine("Area of Square: "+  radius * radius);
    //    }


    //}
    #endregion
    #region Override
    //public class Student
    //{
    //    public virtual void GetInfo()
    //    {
    //        Console.WriteLine("students");
    //    }
    //}
    //// Derived Class
    //public class Teacher : Student
    //{
    //    public override void GetInfo()
    //    {
    //        Console.WriteLine("teacher");
    //    }
    //}
    #endregion
    class Employee
    {
        public static void Main(string[] args)
        {
            //Student Stud = new Student();
            //Stud.GetInfo();
            //Student Stud1 = new Teacher();
            //Stud1.GetInfo();

            //Calculation Cal = new Calculation();
            //Cal.Area(10,20);
            //Cal.Area(10);

            //Student stud = new Student();

            //stud.FirstName = "Rahul";
            //stud.LasttName = "Sharma";
            //stud.Age = 22;
            //stud.RollNo = 10;
            //stud.Fees = 10000;
            //stud.ShowDetails();

            //Console.WriteLine("-------------------------");
            //Teacher tr = new Teacher();
            //tr.FirstName = "Kaushik";
            //tr.LasttName = "Bansi";
            //tr.Age = 42;
            //tr.Salary = 40000;
            //tr.ShowDetails();

            //Console.ReadLine();
            //EmpSalary Sal = new EmpSalary();
            //Sal.Showempname();
            //Sal.Empsalary();
        }
    }
}
   

