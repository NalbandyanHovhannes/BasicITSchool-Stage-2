using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_DataStructures
{
   public class HashSet
    {
        public  void HashMethod()
        {
            Console.WriteLine("-----Custom HashSet With Duplicates----");
            HashSet<Employee> employees = new HashSet<Employee> {
                {
                    new Employee {
                        Emp_Id = 1, Emp_name = "Rajeev", Dept_name = "IT"
                    }
                },
                {
                    new Employee {
                        Emp_Id = 1, Emp_name = "Rajeev", Dept_name = "IT"
                    }
                },
                {
                    new Employee {
                        Emp_Id = 3, Emp_name = "Akash", Dept_name = "IT"
                    }
                },
                {
                    new Employee {
                        Emp_Id = 4, Emp_name = "Amit", Dept_name = "IT"
                    }
                }
            };
            Console.WriteLine("{0,-6}{1,10}{2,-8}", "Emp_Id", "Emp_name", "Dept_name");
            Console.WriteLine("==============================");
            foreach (var employee in employees)
            {
                Console.WriteLine("{0,-8}{1,-10}{2,5}", employee.Emp_Id, employee.Emp_name, employee.Dept_name);
            }
            Console.WriteLine("==============================");
            Console.ReadKey();
        }
    }
    public class Employee : IEquatable<Employee>
    {
        public int Emp_Id
        {
            get;
            set;
        }
        public string Emp_name
        {
            get;
            set;
        }
        public string Dept_name
        {
            get;
            set;
        }
        public bool Equals(Employee other)
        {
            return this.Emp_Id.Equals(other.Emp_Id);
        }
        public override int GetHashCode()
        {
            return this.Emp_Id.GetHashCode();
        }
    }
}
    

