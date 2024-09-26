using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSProject
{
   public class Vacation
    {
        public int Vacation_ID { get; set; }
        public int employeeID { get; set; }
        public int numberOfDays { get; set; }

        public Vacation()
        {

        }
        public Vacation(int vacation_ID, int employeeID, int numberOfDays)
        {
            Vacation_ID = vacation_ID;
            this.employeeID = employeeID;
            this.numberOfDays = numberOfDays;
        }


        // veiw vication days
        public void view_vacation()
        {
            Console.WriteLine("\n\t\t" + Vacation_ID + "\t\t" + employeeID + "\t\t" + numberOfDays);

        }

    }
}
