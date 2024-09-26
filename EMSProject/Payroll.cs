using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSProject
{
    public class Payroll
    {
        public int Payroll_ID { get; set; }
        public int employeeID { get; set; }
        public double  hours_worked { get; set; }
        public double hourly_rate { get; set; }
        public string date { get; set; }

        public Payroll()
        {

        }
        public Payroll(int payroll_ID, int employeeID, double hours_worked, double hourly_rate, string date)
        {
            Payroll_ID = payroll_ID;
            this.employeeID = employeeID;
            this.hours_worked = hours_worked;
            this.hourly_rate = hourly_rate;
            this.date = date;
        }

        public static List<Payroll> Insert_New_Entry(List<Payroll> payroll, Payroll pay)
        {
            payroll.Add(pay);
            return payroll;
        }

        public void Veiw_history()
        {
            Console.WriteLine("\n\t\t" + Payroll_ID + "\t\t" + employeeID + "\t\t" + hours_worked + "\t\t" + hourly_rate + "\t\t" + date);

        }
        
    }
}
