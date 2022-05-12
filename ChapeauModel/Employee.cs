using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Employee
    {
        public int EmployeeID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string DisplayName { get { return ($"{FirstName} {LastName[0]}."); } }
        
        public JobPosition Position { get; set; }

        public int Pincode { get; set; }

    }
}
