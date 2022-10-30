using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EmployeeManagementSystem

{

    public interface IPrintable

    {

        void DisplayEmployeeDetails();

    }

    public class Employee

    {

        public int emp_id;

        public string emp_name;

        public float Salary;

        public float GrossSalary;

        public void GetSalaryWithEmployeeDetails()

        {

            WriteLine("Enter Employee Details Like emp_id,emp_name");

            emp_id = int.Parse(ReadLine());
            emp_name = ReadLine();
            Console.WriteLine("Enter Salary of an Employe .");

            Salary = float.Parse(ReadLine());

        }

        public virtual void CalculateSalary()

        {

        }

    }
    public class Manager : Employee, IPrintable

    {

        private float PA;

        private float FA;

        private float OA;

        public override void CalculateSalary()

        {

            PA = 8 * Salary / 100;

            FA = 13 * Salary / 100;

            OA = 3 * Salary / 100;

            GrossSalary = Salary + PA + FA + OA;

        }

        public void DisplayEmployeeDetails()

        {

            WriteLine("Manager Details...");

            WriteLine("emp_id: {0}\nemp_name: {1}\nGrossSalary:{2}", emp_id, emp_name, GrossSalary);

        }

    }
    public class MarketingExecutive : Employee, IPrintable
    //inherited Employee class and interface IEmployee

    {
        private int Distance;
        private float TourAllowances;
        private float Telephone_Allowances;

        public override void CalculateSalary() //override method of Employee class

        {

            WriteLine("Enter Distance travelled during Marketing Executive in km");

            Distance = int.Parse(ReadLine());//taking distance input

            TourAllowances = 5 * Distance; //5 rupees per km

            Telephone_Allowances = 1000;

            GrossSalary = Salary + TourAllowances + Telephone_Allowances;

        }

        public void DisplayEmployeeDetails() //implementation of interface method

        {

            WriteLine("Marketing Executive Details....");

            WriteLine("emp_id: {0}\n emp_name: {1}\nGross Salary:{2}", emp_id, emp_name, GrossSalary);

        }

    }
    internal class Program

    {

        static void Main(string[] args)

        {

            Manager mg = new Manager();

            MarketingExecutive me = new MarketingExecutive();

            WriteLine("Manager Input");

            mg.GetSalaryWithEmployeeDetails();

            mg.CalculateSalary();

            mg.DisplayEmployeeDetails();

            WriteLine("Marketing Executive Input");

            me.GetSalaryWithEmployeeDetails();

            me.CalculateSalary();

            me.DisplayEmployeeDetails();

            Console.ReadKey();

        }
    }
}