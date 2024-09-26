using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSProject
{
    public  class Employee 
    {

        public int Empolyee_ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public string Role { get; set; }

        public Employee()
        {

        }
        public Employee(int empolyee_ID, string name, string address, string email, long phone, string role)
        {
            Empolyee_ID = empolyee_ID;
            Name = name;
            Address = address;
            Email = email;
            Phone = phone;
            Role = role;
        }

        public void ListAllEmpolyee()
        {
            Console.WriteLine("\n\t"+Empolyee_ID+ "\t" + Name+ "\t" + Email+ "\t" + Phone+ "\t" + Address+ "\t" + Role);
          

        }

        public static List<Employee> Add_Employee(List<Employee> employee, Employee emp)
        {
            
            employee.Add(emp);
            return employee;
            
        }
       

    }
}
