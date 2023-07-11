using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ID;
            string EmployeeName;
            char EmployeeGender;
            double EmployeeSalary;
            DateTime doj;
            Console.WriteLine("Enter ID");
            ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter EmployeeName");
            EmployeeName = Console.ReadLine();
            Console.WriteLine("Enter EmployeeGender");
            EmployeeGender = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Salary");
            EmployeeSalary = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Date of joining");
            doj = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("ID : \t" + ID + "\n EmployeeName :" + EmployeeName + "\n EmployeeGender :" + EmployeeGender + "\n EmployeeSalary" + EmployeeSalary + "\n doj" + doj);
            Console.ReadKey();


        }
    }
}
