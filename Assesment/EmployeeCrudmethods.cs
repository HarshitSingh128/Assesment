using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assesment
{
    public class EmployeeCrudmethods
    {

        static List<Employee1> list = new List<Employee1>();
        public void Addemployee()
        {

            Console.WriteLine("Add Employee");
            Console.WriteLine("Enter the number of Employee you want to add: ");
            int size = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter Employee Id:");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Employee Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Employee Salary:");
                double salary = Convert.ToDouble(Console.ReadLine());
                list.Add(new Employee1(id, name, salary));
            }
        }
        public void ShowallEmployee()
        {
            Console.WriteLine("Show all details");
            foreach (var s in list)
            {
                Console.WriteLine("EmployeeId:" + s.Eid + " " + "EmployeeName:" + s.Ename + " " + "Employeesalary:" + s.Esalary);
            }

        }
        public void UpdateEmployee()
        {
            Console.WriteLine("Update Employee:");
            Console.WriteLine("Enter the Employee id you want to update:");
            int id = Convert.ToInt32(Console.ReadLine());
            Employee1 employee = list.Find(emp => emp.Eid == id);
            if (employee != null)
            {

                Console.WriteLine("Enter New Employee Name: ");
                string name = Console.ReadLine();
                employee.Ename = name;

                Console.WriteLine("Enter New Employee Salary: ");
                double salary = Convert.ToDouble(Console.ReadLine());
                employee.Esalary = salary;

                Console.WriteLine("Employee updated successfully!");
            }
            else
            {
                Console.WriteLine($"Employee with ID {id} not found!");
            }
        }
        public void DeleteEmployee()
        {
            Console.WriteLine("Delete Employee");
            Console.WriteLine("Enter Employee ID to delete: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Employee1 employee = list.Find(emp => emp.Eid == id);

            if (employee != null)
            {
                list.Remove(employee);
                Console.WriteLine("Employee deleted successfully!");
            }
            else
            {
                Console.WriteLine($"Employee with ID {id} not found!");
            }
        }

    }
}
        
        






    
        




       
    

