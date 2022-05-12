using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    class PaymentService
    {
        PaymentDAO paymentdb;

        public PaymentService()
        {
            paymentdb = new PaymentDAO();
        }

        public void TakePayment()
        {
            //.....
        }

    }
}
