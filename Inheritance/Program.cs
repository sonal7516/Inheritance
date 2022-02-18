using System;

namespace Inheritance
{
    class Employee
    {
        public string EmpName;
        public int EmpID;
        public int Salary;


    }
    class VistingEmployee : Employee
    {
       
    }



    class Program
    {

        static void Main(string[] args)
        {

            VistingEmployee Sonal = new VistingEmployee();
                Sonal.EmpID = 1456;
            Sonal.Salary = 50000;
                Sonal.EmpName = "Sonal";

            Console.WriteLine("Sonal Employee ID is:{0}", Sonal.EmpID);
            Console.WriteLine("Sonal Salary is:{0}", Sonal.Salary);




            Console.ReadLine();
        }
    }
}

