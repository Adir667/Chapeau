using ChapeauLogic;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class KitchenBar : Form
    {
        OrderService orderService = new OrderService();
        TableService tableService = new TableService();

        private bool drinks = false;
        private bool history = false;

        public KitchenBar(Employee employee)
        {
            InitializeComponent();

            if (employee.Position == JobPosition.Bartender)
            {
                drinks = true;
            }

            lblUsername.Text = $"User: {employee.DisplayName}";

            btnReady.Enabled = false;
            LoadOrders(history, drinks);
        }

        private void LoadOrders(bool history, bool drinks)
        {
            try
            {
                ShowHeadline();
                btnReady.Show();
                LVItem.Items.Clear();

                List<Order> ordersList = orderService.GetOrders(drinks, history);
                ShowOrders(ordersList);
            }
            catch (Exception ex)
            {
                ErrorProcess(ex, "Something went wrong while loading the orders");
            }
        }

        private void ShowOrders(List<Order> orders)
        {
            try
            {
                LVOrder.Items.Clear();
                foreach (Order order in orders)
                {
                    ListViewItem li = new ListViewItem(order.OrderID.ToString());
                    li.SubItems.Add(order.Table.TableNr.ToString());
                    li.SubItems.Add(order.TimeStamp.ToString("HH:mm"));
                    li.SubItems.Add(order.Employee.DisplayName);
                    li.Tag = order;
                    LVOrder.Items.Add(li);
                }
            }
            catch (Exception ex)
            {
                ErrorProcess(ex, "Something went wrong while loading the items");
            }
        }

        private void LVOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowHeadline();

            btnReady.Enabled = ((LVOrder.SelectedItems.Count > 0) && (!history));

            if (LVOrder.SelectedItems.Count > 0)
            {
                Order order = (Order)LVOrder.SelectedItems[0].Tag;
                ShowItems(order, drinks, history);
                lblTableNr.Text += $"Table# {order.Table.TableNr}";
            }
        }

        private void ShowItems(Order order, bool drinks, bool history)
        {
            try
            {
                List<OrderItem> orderItems = orderService.GetItems(order, drinks, history);
                LVItem.Items.Clear();

                foreach (OrderItem item in orderItems)
                {
                    ListViewItem li = new ListViewItem(item.Item.Name.ToString());
                    li.SubItems.Add(item.Amount.ToString());
                    li.SubItems.Add(item.Status.ToString());
                    li.SubItems.Add(item.TimeStamp.ToString("HH:mm:ss"));
                    li.SubItems.Add(item.Remark.ToString());
                    li.Tag = item;
                    LVItem.Items.Add(li);
                }
            }
            catch (Exception ex)
            {
                ErrorProcess(ex, "Something went wrong while loading the items of the order");
            }
        }

        private void ShowHeadline()
        {
            lblDateTime.Text = DateTime.Now.ToString("HH:mm\ndd/MM/yyyy");

            if (drinks)
            {
                this.Text = "BAR";
                lblSection.Text = "BAR";
            }
            else
            {
                this.Text = "KITCHEN";
                lblSection.Text = "KITCHEN";
            }
            if (history)
            {
                this.Text += " HISTORY";
                lblSection.Text += " HISTORY";
            }
            lblTableNr.Text = "";
        }

        #region buttons

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnReady.BackColor = Color.FromArgb(140, 236, 146);
            history = false;
            LoadOrders(history, drinks);
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            ChangeItemStatus("Attention!", $"No specific items were selected, Therefore all items in the order will be marked as READY.\nProceed?", OrderItemStatus.Ready);
        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
            login.Closed += (s, args) => this.Close();
        }
         
        private void btnHistory_Click(object sender, EventArgs e)
        {
            history = true;
            LoadOrders(history, drinks);
            btnReady.BackColor = Color.Black;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            ChangeItemStatus("Attention!", $"No specific items were selected, Therefore all items in the order will be marked back as WAITING.\nProceed?", OrderItemStatus.Waiting);
        }

        #endregion

        private void ChangeItemStatus(string headline, string message, OrderItemStatus orderItemStatus)
        {
            Order order = (Order)LVOrder.SelectedItems[0].Tag;

            if (LVItem.SelectedItems.Count == 0)
            {
                DialogResult dialogResult = MessageBox.Show(message, headline, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    List<OrderItem> orderItems = orderService.GetItems(order, drinks, history);
                    foreach (OrderItem item in orderItems)
                    {
                        item.Status = orderItemStatus;
                        orderService.UpdateStatus(item, order);
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                for (int i = 0; i < LVItem.SelectedItems.Count; i++)
                {
                    OrderItem item = (OrderItem)LVItem.SelectedItems[i].Tag;
                    item.Status = orderItemStatus;
                    orderService.UpdateStatus(item, order);
                }
            }
            tableService.FoodIsReady(order.Table);
            LoadOrders(history, drinks);
        }

        private void ErrorProcess(Exception ex, string messege)
        {
            MessageBox.Show(messege, "Error occured");

            // write to error log file
            StreamWriter sw = File.AppendText("..\\..\\..\\Error Log.txt");
            sw.WriteLine($"Error occured at: {DateTime.Now}:");
            sw.WriteLine(messege);
            Console.WriteLine(ex);
            Console.WriteLine();
            sw.Close();
        }

    }
}
