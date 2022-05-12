using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Order
    {
        public int OrderID { get; set; }

        public List<OrderItem> OrderItems { get; set; }

        public Table Table { get; set; }

        public Employee Employee { get; set; }

        public DateTime TimeStamp { get; set; }

        public bool Paid { get; set; }


    }
}
