using ChapeauModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class Payment : Form
    {
        private double vat;
        private double total;
        private List<PaymentMethod> methods = new List<PaymentMethod>();
        PaymentMethod cash = PaymentMethod.Cash;
        PaymentMethod debit = PaymentMethod.DebitCard;
        PaymentMethod credit = PaymentMethod.CreditCard;




        public Payment(Order order)
        {
            InitializeComponent();

            methods.Add(cash);
            methods.Add(credit);
            methods.Add(debit);

            txtTip.Text = "0";

            lblHeadline.Text = $"Payment: Table {order.Table.TableNr}";
            lvPaymentMethod.Items.Clear();
            lvPayment.Items.Clear();

            foreach (PaymentMethod method in methods)
            {
                ListViewItem li = new ListViewItem(method.ToString());
                li.Tag = method;
                lvPaymentMethod.Items.Add(li);
            }

            foreach (OrderItem orderItem in order.OrderItems)
            {
                ListViewItem li = new ListViewItem(orderItem.Item.Name.ToString());
                li.SubItems.Add(orderItem.Amount.ToString());
                li.SubItems.Add(orderItem.Item.Price.ToString());
                li.SubItems.Add((orderItem.Item.Price * orderItem.Amount).ToString());

                li.Tag = orderItem;
                lvPayment.Items.Add(li);

                vat += orderItem.Item.Price * orderItem.Item.Vat * orderItem.Amount;
                total += orderItem.Item.Price * orderItem.Amount;
            }

            lblToalAmount.Text = $"Total: {total}";
            txtPayment.Text = total.ToString();
            lblVat.Text = $"VAT: {vat}";
        }
    }
}
