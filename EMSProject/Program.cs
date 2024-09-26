using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSProject
{
    public class Program
    {
        static void Main(string[] args)
        {

            int choice = 0;
            int choice2 = 0;

            // Pre loaded empolyee details
            List<Employee> employee = new List<Employee>();
            employee.Add(new Employee(1, "Sample1", "Aaa", "Sample1@gmail.com", 123, "Admin"));
            employee.Add(new Employee(2, "Sample2", "Bbb", "Sample2@gmail.com", 321, "Developer"));
            employee.Add(new Employee(3, "Sample3", "Ccc", "Sample3@gmail.com", 456, "User"));
            employee.Add(new Employee(4, "Sample4", "Ddd", "Sample4@gmail.com", 654, "Admin"));
            employee.Add(new Employee(5, "Sample5", "Eee", "Sample5@gmail.com", 789, "Superviser"));


            // Pre loaded Payroll details
            List<Payroll> payrolls = new List<Payroll>();
            payrolls.Add(new Payroll(1, 23, 2.5, 54, "12/12/2010"));
            payrolls.Add(new Payroll(2, 24, 2.5, 54, "12/12/2010"));
            payrolls.Add(new Payroll(3, 25, 2.5, 54, "12/12/2010"));
            payrolls.Add(new Payroll(4, 26, 2.5, 54, "12/12/2010"));
            payrolls.Add(new Payroll(5, 26, 2.5, 54, "12/12/2010"));

            // Pre loaded vacation details
            List<Vacation> vacations = new List<Vacation>();
            vacations.Add(new Vacation(1, 23, 5));
            vacations.Add(new Vacation(2, 24, 5));
            vacations.Add(new Vacation(3, 25, 5));
            vacations.Add(new Vacation(4, 24, 5));
            vacations.Add(new Vacation(5, 25, 5));

#pragma warning disable CS0164 
        Main_Menu:
#pragma warning restore CS0164
            Console.WriteLine("\n.................Empolyee Managment System.................\n\n");
            Console.WriteLine("Welcome To Main Menu, Please Enter Your Choice\n");
            Console.WriteLine("Press 1 to modify empolyees");
            Console.WriteLine("Press 2 to add payroll");
            Console.WriteLine("Press 3 to view vacation days");
            Console.WriteLine("Press 4 to exit Program");

            Console.Write("\nEnter Your Choice : ");
            string input = Console.ReadLine();

            while (true)
            {
                if (int.TryParse(input, out choice))
                {

                    if (choice.Equals(1))
                    {
                        Console.WriteLine("1 Press");
                        Console.Clear();
                        Console.WriteLine("\n.................Empolyee Managment System.................\n\n");
                        Console.WriteLine("Welcome To Empolyee, Please Enter Your Choice\n");
                        Console.WriteLine("Press 1 to list all employees");
                        Console.WriteLine("Press 2 to add a new employee");
                        Console.WriteLine("Press 3 to Update employee");
                        Console.WriteLine("Press 4 to Delete employee");
                        Console.WriteLine("Press 5 to return to main menu");

                        Console.Write("\nEnter Your Choice : ");
                        string input2 = Console.ReadLine();

                        while (true)
                        {
                            if (int.TryParse(input2, out choice2))
                            {
                                if (choice2.Equals(1))
                                {
                                    Console.WriteLine("\t\t\t-------Empolyee Details-------");
                                    Console.WriteLine("\n\tID \t Name \t\t Email \t\tPhone \t Address \t Role");
                                    
                                    employee.ForEach(p => p.ListAllEmpolyee());
                                    
                                    Console.Write("\nEnter Your Choice : ");
                                    input2 = Console.ReadLine();
                                }
                                else if (choice2.Equals(2))
                                {
                                    Console.WriteLine("\n\t\t\t------- Add Empolyee -------");

                                    Employee emp = new Employee();
                                    Console.Write("Enter Empolyee ID : ");
                                    int Emp_id = Convert.ToInt32(Console.ReadLine());
                                    var empinfo = employee.Where(e => e.Empolyee_ID == Emp_id).FirstOrDefault();

                                    if (empinfo == null) { 
                                        empinfo = emp;
                                        empinfo.Empolyee_ID = 0;
                                    }


#pragma warning disable CS0472 
                                    if (Emp_id != null)
#pragma warning restore CS0472 
                                    {
                                        if (empinfo.Empolyee_ID != Emp_id  || empinfo.Empolyee_ID == null)
                                        {
                                            emp.Empolyee_ID = Emp_id;
                                            Console.Write("Enter Name : ");
                                            emp.Name = Console.ReadLine();
                                            Console.Write("Enter Email : ");
                                            emp.Email = Console.ReadLine();
                                            Console.Write("Enter Address : ");
                                            emp.Address = Console.ReadLine();
                                            Console.Write("Enter Phone : ");
                                            emp.Phone = Convert.ToInt32(Console.ReadLine());
                                            Console.Write("Enter Role : ");
                                            emp.Role = Console.ReadLine();

                                            employee.Where(e => e.Empolyee_ID == emp.Empolyee_ID);
                                            employee.Where(e => e.Name == emp.Name);
                                            employee.Where(e => e.Email == emp.Email);
                                            employee.Where(e => e.Address == emp.Address);
                                            employee.Where(e => e.Phone == emp.Phone);
                                            employee.Where(e => e.Role == emp.Role);
                                            employee.Add(emp);

                                            Console.WriteLine("\n\tEmployee with id: " + Emp_id + " Added successfully");
                                        }
                                        else
                                        {
                                            Console.WriteLine("\n\tEmployee " + empinfo.Empolyee_ID + " Already Exist, Choice Again Options");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Employee with id: " + Emp_id + " does not exist");
                                    }
                                        Console.Write("\nEnter Your Choice : ");
                                    input2 = Console.ReadLine();
                                }
                                else if (choice2.Equals(3))
                                {
                                    
                                    Console.Write("Enter Empolyee_ID for Update Empolyee Profile : ");
                                    int emp_id = Convert.ToInt32( Console.ReadLine());
                                    Employee emp = new Employee();
                                   
                                        var empinfo = employee.Where(e => e.Empolyee_ID == emp_id).FirstOrDefault();
                                        if (empinfo != null)
                                        {
                                            emp.Empolyee_ID = emp_id;
                                            Console.Write("Enter Name : ");
                                            emp.Name = Console.ReadLine();
                                            Console.Write("Enter Email : ");
                                            emp.Email = Console.ReadLine();
                                            Console.Write("Enter Address : ");
                                            emp.Address = Console.ReadLine();
                                            Console.Write("Enter Phone : ");
                                            emp.Phone = Convert.ToInt32(Console.ReadLine());
                                            Console.Write("Enter Role : ");
                                            emp.Role = Console.ReadLine();

                                            employee.Where(e => e.Empolyee_ID == emp_id).FirstOrDefault().Empolyee_ID = emp.Empolyee_ID;
                                            employee.Where(e => e.Empolyee_ID == emp_id).FirstOrDefault().Name = emp.Name;
                                            employee.Where(e => e.Empolyee_ID == emp_id).FirstOrDefault().Email = emp.Email;
                                            employee.Where(e => e.Empolyee_ID == emp_id).FirstOrDefault().Address = emp.Address;
                                            employee.Where(e => e.Empolyee_ID == emp_id).FirstOrDefault().Phone = emp.Phone;
                                            employee.Where(e => e.Empolyee_ID == emp_id).FirstOrDefault().Role = emp.Role;

                                            Console.WriteLine("\n\tEmployee with id: " + emp_id + " updated successfully");

                                            
                                        }
                                        else
                                        {
                                            Console.WriteLine("\n\tEmployee with id: " + emp_id + " does not exist.");
                                            
                                        }

                                    
                                    Console.Write("\nEnter Your Choice : ");
                                    input2 = Console.ReadLine();
                                }
                                else if (choice2.Equals(4))
                                {
                                    Console.Write("\n\tEnter Empolyee_ID TO Delete Empolyee! : ");
                                    int emp_id = Convert.ToInt32 (Console.ReadLine());
                                    employee.RemoveAll(e => e.Empolyee_ID == emp_id);
                                    
                                    Console.Write("\nEnter Your Choice : ");
                                    input2 = Console.ReadLine();
                                }
                                else if (choice2.Equals(5))
                                {
                                    Console.Clear();
                                    goto Main_Menu;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Choice, Try Again");
                                    Console.Write("\nEnter Your Choice : ");
                                    input2 = Console.ReadLine();
                                }


                            }
                            else
                            {
                                Console.WriteLine("Invalid Choice, Try Again");
                                Console.Write("\nEnter Your Choice : ");
                                input2 = Console.ReadLine();
                            }
                        }
                    }
                    else if (choice.Equals(2))
                    {
                        Console.WriteLine("2 Press");
                        Console.Clear();
                        Console.WriteLine("\n.................Empolyee Managment System.................\n\n");
                        Console.WriteLine("Welcome To Payroll, Please Enter Your Choice\n");
                        Console.WriteLine("Press 1 to Insert new payroll entry");
                        Console.WriteLine("Press 2 view payroll history for an employee");
                        Console.WriteLine("Press 3 to return to main menu");

                        Console.Write("\nEnter Your Choice : ");
                        string input2 = Console.ReadLine();

                        while (true)
                        {
                            if (int.TryParse(input2, out choice2))
                            {
                                if (choice2.Equals(1))
                                {
                                    Payroll pay = new Payroll();
                                    Console.Write("Enter Payroll ID : ");
                                    int pay_id = Convert.ToInt32(Console.ReadLine());
                                    var payinfo = payrolls.Where(e => e.Payroll_ID == pay_id).FirstOrDefault();

                                    if (payinfo == null)
                                    {
                                        payinfo = pay;
                                        payinfo.Payroll_ID = 0;
                                    }


#pragma warning disable CS0472 
                                    if (pay_id != null)
#pragma warning restore CS0472 
                                    {
                                        if (payinfo.Payroll_ID != pay_id || payinfo.Payroll_ID == null)
                                        {
                                            pay.Payroll_ID = pay_id;
                                            Console.Write("Enter empolyee ID : ");
                                            Console.Write("Enter Worked Hours : ");
                                            pay.hours_worked = Convert.ToDouble(Console.ReadLine());
                                            Console.Write("Enter Hourly Rate : ");
                                            pay.hourly_rate = Convert.ToDouble(Console.ReadLine());
                                            Console.Write("Enter Date --12/12/2020-- : ");
                                            pay.date = Console.ReadLine();


                                            payrolls.Where(e => e.Payroll_ID == pay.Payroll_ID);
                                            payrolls.Where(e => e.employeeID == pay.employeeID);
                                            payrolls.Where(e => e.hours_worked == pay.hours_worked);
                                            payrolls.Where(e => e.hourly_rate == pay.hourly_rate);
                                            payrolls.Where(e => e.date == pay.date);

                                            payrolls.Add(pay);

                                            Console.WriteLine("\n\tEmployee with id: " + pay_id + " Added successfully");
                                        }
                                        else
                                        {
                                            Console.WriteLine("\n\tEmployee " + pay_id + " Already Exist, Choice Again Options");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Employee with id: " + pay_id + " does not exist");
                                    }


                                    Console.Write("\nEnter Your Choice : ");
                                    input2 = Console.ReadLine();
                                }
                                else if (choice2.Equals(2))
                                {
                                    Console.WriteLine("\n  \t\t\t\t-------Payroll Details-------");
                                    Console.WriteLine("\n\t\tPay_ID \t\tEmp_ID\t\tWork_hours\thourly_work\tDate \t");
                                    payrolls.ForEach(p => p.Veiw_history());

                                    Console.Write("\nEnter Your Choice : ");
                                    input2 = Console.ReadLine();
                                }
                                else if (choice2.Equals(3))
                                {
                                    Console.Clear();
                                    goto Main_Menu;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Choice, Try Again");
                                    Console.Write("\nEnter Your Choice : ");
                                    input2 = Console.ReadLine();
                                }


                            }
                            else
                            {
                                Console.WriteLine("Invalid Choice, Try Again");
                                Console.Write("\nEnter Your Choice : ");
                                input2 = Console.ReadLine();
                            }
                        }

                    }
                    else if (choice.Equals(3))
                    {
                        Console.WriteLine("3 Press");
                        Console.Clear();
                        Console.WriteLine("\n.................Empolyee Managment System.................\n\n");
                        Console.WriteLine("Welcome To Vacation, Please Enter Your Choice\n");
                        Console.WriteLine("Press 1 to view vacation days");
                        Console.WriteLine("Press 2 to Add vacation days");
                        Console.WriteLine("Press 3 to exit Program");


                        Console.Write("\nEnter Your Choice : ");
                        string input2 = Console.ReadLine();

                        while (true)
                        {
                            if (int.TryParse(input2, out choice2))
                            {
                                if (choice2.Equals(1))
                                {

                                    Console.WriteLine("\n\n\t\t  -------Vacation Details-------");
                                    Console.WriteLine("\n\t\tVac_ID \t\tEmp_ID\t\tno_days\t\t");
                                    vacations.ForEach(p => p.view_vacation());

                                    Console.Write("\nEnter Your Choice : ");
                                    input2 = Console.ReadLine();
                                }
                                else if (choice2.Equals(2))
                                {
                                    Vacation vac = new Vacation();
                                    Console.Write("\nEnter Vacation ID : ");
                                    int vac_id = Convert.ToInt32(Console.ReadLine());
                                    var vacinfo = vacations.Where(e => e.Vacation_ID == vac_id).FirstOrDefault();

                                    if (vacinfo == null)
                                    {
                                        vacinfo = vac;
                                        vacinfo.Vacation_ID = 0;
                                    }


#pragma warning disable CS0472 
                                    if (vac_id != null)
#pragma warning restore CS0472 
                                    {
                                        if (vacinfo.Vacation_ID != vac_id || vacinfo.Vacation_ID == null)
                                        {
                                            vac.Vacation_ID = vac_id;
                                            Console.Write("Enter Empolyee ID : ");
                                            vac.employeeID = Convert.ToInt32(Console.ReadLine());
                                            Console.Write("Enter numberOfDays: ");
                                            vac.numberOfDays =Convert.ToInt32(Console.ReadLine());
                                            
                                            
                                            vacations.Where(e => e.Vacation_ID == vac.Vacation_ID);
                                            vacations.Where(e => e.employeeID == vac.employeeID);
                                            vacations.Where(e => e.numberOfDays == vac.numberOfDays);

                                            vacations.Add(vac);

                                            Console.WriteLine("\n\t Vacation with id: " + vac_id + " Added successfully");
                                        }
                                        else
                                        {
                                            Console.WriteLine("\n\t Vacation with id: " + vac_id + " Already Exist, Choice Again Options");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Vacation with id: " + vac_id + " does not exist");
                                    }
                                    Console.Write("\nEnter Your Choice : ");
                                    input2 = Console.ReadLine();

                                }
                                else if (choice2.Equals(3))
                                {
                                    Console.Clear();
                                    goto Main_Menu;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Choice, Try Again");
                                    Console.Write("\nEnter Your Choice : ");
                                    input2 = Console.ReadLine();
                                }


                            }
                            else
                            {
                                Console.WriteLine("Invalid Choice, Try Again");
                                Console.Write("\nEnter Your Choice : ");
                                input2 = Console.ReadLine();
                            }
                        }



                    }
                    else if (choice.Equals(4))
                    {
                        Console.WriteLine("4 Press");
                        Console.Clear();
                        System.Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Choice invaild, Try Again");
                        Console.Write("\nEnter Your Choice : ");
                        input = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Choice invaild, Try Again");
                    Console.Write("\nEnter Your Choice : ");
                    input = Console.ReadLine();
                }

            }
    

        }
        
    }
}
