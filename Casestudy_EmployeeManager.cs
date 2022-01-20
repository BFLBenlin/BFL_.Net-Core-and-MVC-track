using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Employee
    {
        public int Emp_id { set; get; }
        public string Emp_name { set; get; }
        public string Department { set; get; }
        public string Designation { set; get; }

        Employee[] newEmp = new Employee[10];


        public void GetEmpDetails(int n)
        {
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Employee ID");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Employee Name");
                string b = Console.ReadLine();
                Console.WriteLine("Department Name");
                string c = Console.ReadLine();
                Console.WriteLine("Designation");
                string d = Console.ReadLine();

                newEmp[i] = new Employee { Emp_id = a, Emp_name = b, Department = c, Designation = d };
            }
        }

        public void displayEmployee(int E_id)
        {
            Console.WriteLine("Employee iD " + newEmp[E_id].Emp_id);
            Console.WriteLine("Employee Name " + newEmp[E_id].Emp_name);
            Console.WriteLine("Employee Department " + newEmp[E_id].Department);
            Console.WriteLine("Employee Designation " + newEmp[E_id].Designation);
        }
    }

    class Department
    {
        public string Dep_name { set; get; }
        Department[] newDep;
        public void GetDepDetails()
        {
            Department[] newDep = new Department[3];
            newDep[0] = new Department { Dep_name = "IT" };
            newDep[1] = new Department { Dep_name = "Market" };
            newDep[2] = new Department { Dep_name = "Service" };
        }


    public void displayDepartment(int E_id)
        {
            Console.WriteLine("Department " + newDep[E_id].Dep_name);
        }
    }

    class Salary 
    {
        public int Basic { set; get; }
        public int Da { set; get; }
        public int Pf { set; get; }
        public int Gross { set; get; }
        public int Net { set; get; }

        Salary[] newSal = new Salary[10];

        public void GetSalDetails(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the basic salary");
                int k = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the da salary");
                int l = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the pf salary");
                int m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the gross salary");
                int o = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the net salary");
                int q = Convert.ToInt32(Console.ReadLine());

                newSal[i] = new Salary { Basic = k, Da = l, Pf = m, Gross = o, Net = q };
            }
        }
        public void displaySalary(int E_id)
        {
            Console.WriteLine("Employee basic salary " + newSal[E_id].Basic);
            Console.WriteLine("Employee da salary " + newSal[E_id].Da);
            Console.WriteLine("Employee pf " + newSal[E_id].Pf);
            Console.WriteLine("Employee gross salary " + newSal[E_id].Gross);
            Console.WriteLine("Employee net salary " + newSal[E_id].Net);
        }
    }

    class Attendance
    {
        public int Absent { set; get; }
        public int Leave { set; get; }
        public int Present { set; get; }

        Attendance[] newAtt = new Attendance[10];

        public void GetAttDetails(int n)
        {

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("No. of days Absent");
                int e = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("No. of leaves");
                int f = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("No. of days present");
                int g = Convert.ToInt32(Console.ReadLine());

                
                newAtt[i] = new Attendance { Absent = e, Leave = f, Present = g };
            }
        }
        public void displayAttendance(int E_id)
        {
            Console.WriteLine("Employee basic salary " + newAtt[E_id].Absent);
            Console.WriteLine("Employee da salary " + newAtt[E_id].Leave);
            Console.WriteLine("Employee pf " + newAtt[E_id].Present);
        }
    }

    class Manager : Employee
    {
        public void GetManDetails()
        {
            Manager[] newMan = new Manager[3];
            newMan[0] = new Manager { Emp_id = 201 ,Emp_name = "John",Department = "IT", Designation = "Manager" };
            newMan[1] = new Manager { Emp_id = 202, Emp_name = "Peter", Department = "Market", Designation = "Manager" };
            newMan[2] = new Manager { Emp_id = 203, Emp_name = "Michael", Department = "Service", Designation = "Manager" };
        }

        public void displayManager(int E_id)
        {
            Console.WriteLine("Enter Manager employee ID to search");
            string m_id = Console.ReadLine();
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();
            Employee emp = new Employee();
            Department dep = new Department();
            Salary sal = new Salary();
            Attendance att = new Attendance();
            Manager man = new Manager();

            dep.GetDepDetails();
            man.GetManDetails();

            int z = 0;
            while(z<1)
            {
                Console.WriteLine("Choose");
                Console.WriteLine("1.Enter Employee Details");
                Console.WriteLine("2.Display Employee Details");
                Console.WriteLine("3.Display Department Details");
                Console.WriteLine("4.Display Manager Details");
                Console.WriteLine("7.Exit");
                int y = Convert.ToInt32(Console.ReadLine());    
                if (y == 1)
                {
                    Console.WriteLine("Number of Employees");
                    int n = Convert.ToInt32(Console.ReadLine());
                    emp.GetEmpDetails(n);
                    sal.GetSalDetails(n);
                    att.GetAttDetails(n);
                }
                else if (y == 2)
                {
                    Console.WriteLine("Enter the Emp ID to Search");
                    int v = Convert.ToInt32(Console.ReadLine());
                    emp.displayEmployee(v);
                    sal.displaySalary(v);
                    att.displayAttendance(v);
                }
                else if (y == 3)
                {
                    Console.WriteLine("Enter the Emp ID to Search");
                    int x = Convert.ToInt32(Console.ReadLine());
                    dep.displayDepartment(x);
                    man.displayManager(x);
                }
                else if (y == 4)
                {
                    Console.WriteLine("Enter the Emp ID to Search");
                    int u = Convert.ToInt32(Console.ReadLine());
                    man.displayManager(u);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
