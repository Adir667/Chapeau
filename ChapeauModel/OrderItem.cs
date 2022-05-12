using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class OrderItem
    {
        public MenuItem Item { get; set; }

        public int Amount { get; set; }

        public OrderItemStatus Status { get; set; }

        public DateTime TimeStamp { get; set; }

        public string Remark { get; set; }
    }
}
