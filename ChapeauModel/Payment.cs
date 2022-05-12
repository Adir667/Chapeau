using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Payment
    {
        public int PaymentID { get; set; }

        public Order Order { get; set; }

        public float Intake { get; set; }

        public PaymentMethod PaymentMethod { get; set; }

        public float Tip { get; set; }

        public string Feedback { get; set; }

        public DateTime TimeStamp { get; set; }

        public float Vat { get; set; }

    }
}
