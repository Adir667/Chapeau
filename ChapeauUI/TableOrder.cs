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
    public partial class TableOrder : Form
    {
        MenuService menuService = new MenuService();
        OrderService orderService = new OrderService();
        TableService tableService = new TableService();

        private Employee employee;
        private Order order;
        private Table table;
        List<OrderItem> orderItems;

        public TableOrder(Table table, Employee employee)
        {
            InitializeComponent();
            this.table = table;
            this.employee = employee;
            order = new Order();
            lblHeadline.Text = $"Table #{table.TableID.ToString()}";
            TimeLbl.Text = DateTime.Now.ToString();
            UserNameTxt.Text = $"User: {employee.DisplayName}";


            if (table.Status == TableStatus.Free)
            {
                orderItems = new List<OrderItem>();
            }
            else
            {
                order = orderService.GetByTable(table);
                orderItems = orderService.GetRunningOrder(order);
                UpdateOverview(orderItems);
            }
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            try
            {
                AmountTxt.Text = "";
                CommentTxt.Text = "";

                LvCatagory.Items.Clear();
                LvSubCatagory.Items.Clear();

                List<MenuCategory> categories = menuService.GetLunch();

                foreach (MenuCategory caterogry in categories)
                {
                    ListViewItem row = new ListViewItem(caterogry.Name.ToString());
                    row.Tag = caterogry;
                    LvCatagory.Items.Add(row);
                }
            }
            catch (Exception ex)
            {
                ErrorProcess(ex, "Something went wrong while loading Lunch");
            }

        }

        private void btnDinner_Click(object sender, EventArgs e)
        {
            try
            {
                AmountTxt.Text = "";
                CommentTxt.Text = "";

                LvCatagory.Items.Clear();
                LvSubCatagory.Items.Clear();

                List<MenuCategory> MenuCategories = menuService.GetDinner();

                foreach (MenuCategory MenuCaterogry in MenuCategories)
                {
                    ListViewItem row = new ListViewItem(MenuCaterogry.Name.ToString());
                    row.Tag = MenuCaterogry;
                    LvCatagory.Items.Add(row);
                }
            }
            catch (Exception ex)
            {
                ErrorProcess(ex, "Something went wrong while loading Dinner");
            }

        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            try
            {
                AmountTxt.Text = "";
                CommentTxt.Text = "";
                
                LvCatagory.Items.Clear();
                LvSubCatagory.Items.Clear();

                List<MenuCategory> MenuCategories = menuService.GetDrinks();

                foreach (MenuCategory MenuCaterogry in MenuCategories)
                {
                    ListViewItem row = new ListViewItem(MenuCaterogry.Name.ToString());
                    row.Tag = MenuCaterogry;
                    LvCatagory.Items.Add(row);
                }
            }
            catch (Exception ex)
            {
                ErrorProcess(ex, "Something went wrong while loading Drinks");
            }

        }

        private void lvItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LvSubCatagory.SelectedItems.Count > 0)
            {
                AmountTxt.Text = "1";
                CommentTxt.Text = "";
            }
        }

        private void lvSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LvSubCatagory.Items.Clear();

                MenuCategory MenuCategory = (MenuCategory)LvCatagory.SelectedItems[0].Tag;
                List<ChapeauModel.MenuItem> menuItems = menuService.GetMenuItem(MenuCategory);

                foreach (ChapeauModel.MenuItem item in menuItems)
                {
                    ListViewItem row = new ListViewItem(item.Name.ToString());
                    row.SubItems.Add(item.Price.ToString());
                    if (item.Stock < 10)
                    {
                        row.SubItems.Add($"{item.Stock} !!");
                    }
                    else
                    {
                        row.SubItems.Add(item.Stock.ToString());
                    }
                    row.Tag = item;
                    LvSubCatagory.Items.Add(row);
                }
            }
            catch
            {
                CommentTxt.Text = "";
                AmountTxt.Text = "";

            }

        }

        private void btnAddItem_Click(object sender, EventArgs e) //
        {
            try
            {               
                OrderItem newAddedItem = new OrderItem();
                newAddedItem.Item = (ChapeauModel.MenuItem)LvSubCatagory.SelectedItems[0].Tag;
                newAddedItem.Amount = int.Parse(AmountTxt.Text);
                newAddedItem.Remark = CommentTxt.Text;
                newAddedItem.TimeStamp = DateTime.Now;

                if (newAddedItem.Amount > newAddedItem.Item.Stock)
                {
                    MessageBox.Show($"Not enough {newAddedItem.Item.Name} in stock!", "Can't add items");
                    return;
                }

                for (int i = 0; i < orderItems.Count; i++)
                {
                    if (orderItems[i].Item.ItemID == newAddedItem.Item.ItemID && orderItems[i].Status == newAddedItem.Status)
                    {
                        newAddedItem.Amount += orderItems[i].Amount;
                        orderItems.Remove(orderItems[i]);
                    }
                }

                orderItems.Add(newAddedItem);
                UpdateOverview(orderItems);
            }
            catch
            {
                MessageBox.Show("Please select an item from menu before adding", "Whoops");
            }

        }

        private void btnCompleteOrder_Click(object sender, EventArgs e)
        {

            try
            {
                if (orderItems.Count == 0)
                {
                    MessageBox.Show("An order can not be completed empty", "Whoops");
                    return;
                }
                if (table.Status == TableStatus.Free)
                {
                    order.OrderID = orderService.GenerateOrderNr();
                    order.Employee = employee;
                    order.Table = table;
                    orderService.CreateOrderItems(order);
                }
                foreach (OrderItem orderItem in orderItems)
                {
                    if (orderItem.Status == OrderItemStatus.Waiting)
                    {
                        orderService.UpdateOrder(order, orderItem);
                        orderItem.Item.Stock -= orderItem.Amount;
                        menuService.UpdateStock(orderItem.Item);
                    }
                }
                table.Status = TableStatus.IsRunning;
                tableService.UpdateStatus(table);
                MessageBox.Show("Order Completed", "Kitchen and bar are informed!");
                UpdateOverview(orderItems);

                Overview overview = new Overview(employee);
                overview.Show();
                this.Hide();
                overview.Closed += (s, args) => this.Close();
            }
            catch (Exception ex)
            {
                ErrorProcess(ex, "Something went wrong while completing the order");
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                OrderItem orderItem = (OrderItem)LvOverview.SelectedItems[0].Tag;
                orderItems.Remove(orderItem);

                UpdateOverview(orderItems);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select an item from overview before removing", "Whoops");
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                Overview overview = new Overview(employee);
                overview.Show();
                this.Hide();
                overview.Closed += (s, args) => this.Close();
            }
            catch (Exception ex)
            {
                ErrorProcess(ex, "Something went wrong while opening the overview");
            }

        }

        private void lvOverview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateOverview(List<OrderItem> orderItems)
        {
            LvOverview.Items.Clear();
            foreach (OrderItem orderItem in orderItems)
            {
                ListViewItem row = new ListViewItem(orderItem.Item.Name.ToString());
                row.SubItems.Add(orderItem.Amount.ToString());
                row.SubItems.Add(orderItem.Remark.ToString());
                row.SubItems.Add(orderItem.Status.ToString());

                row.Tag = orderItem;
                LvOverview.Items.Add(row);
            }
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
