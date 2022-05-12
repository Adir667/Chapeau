using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauLogic;
using ChapeauModel;

namespace ChapeauUI
{
    public partial class Overview : Form
    {
        TableService tableService = new TableService();
        //Table table1, table2, table3, table4, table5, table6, table7, table8, table9, table10;

        List<Table> tables;

        List<Button> buttons;

        Employee employee;
        private List<PictureBox> iconsPB = new List<PictureBox>();

        public Overview(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            tables = tableService.GetAllTables();

            buttons = new List<Button>();

            buttons.Add(btnTable1);
            buttons.Add(btnTable2);
            buttons.Add(btnTable3);
            buttons.Add(btnTable4);
            buttons.Add(btnTable5);
            buttons.Add(btnTable6);
            buttons.Add(btnTable7);
            buttons.Add(btnTable8);
            buttons.Add(btnTable9);
            buttons.Add(btnTable10);


            lblDateTime.Text = DateTime.Now.ToString("HH:mm, dd/MM/yyyy");
            lblUser.Text = $"User: {employee.DisplayName}";


            //table1 = tableService.GetTable(1);
            //table2 = tableService.GetTable(2);
            //table3 = tableService.GetTable(3);
            //table4 = tableService.GetTable(4);
            //table5 = tableService.GetTable(5);
            //table6 = tableService.GetTable(6);
            //table7 = tableService.GetTable(7);
            //table8 = tableService.GetTable(8);
            //table9 = tableService.GetTable(9);
            //table10 = tableService.GetTable(10);

            for (int i = 0; i < 10; i++)
            {
                ShowTable(tables[i], buttons[i]);
            }



            //ShowTable(tables[0], btnTable1);
            //ShowTable2();
            //ShowTable3();
            //ShowTable4();
            //ShowTable5();
            //ShowTable6();
            //ShowTable7();
            //ShowTable8();
            //ShowTable9();
            //ShowTable10();


        }

        public void ShowTable(Table table, Button btn)
        {
            if (table.Status == TableStatus.Free)
            {
                btn.BackColor = Color.FromArgb(140, 236, 146);
                btn.Text += $"\nAvailable";
            }
            else if (table.Status == TableStatus.IsRunning)
            {
                btn.Text += $"\nPreparing...";
            }
            else if (table.Status == TableStatus.FoodIsReady)
            {
                btn.Text += $"\nReady!";
            }
        }
        //public void ShowTable2()
        //{
        //    if (table2.Status == TableStatus.Free)
        //    {
        //        btnTable2.BackColor = Color.FromArgb(140, 236, 146);
        //        btnTable2.Text += $"\nAvailable";
        //    }
        //    else if (table2.Status == TableStatus.Occupied)
        //    {
        //        btnTable2.Text += $"\nOccupied";
        //    }
        //    else if (table2.Status == TableStatus.IsRunning)
        //    {
        //        btnTable2.Text += $"\nPreparing meal";
        //    }
        //    else if (table2.Status == TableStatus.FoodIsReady)
        //    {
        //        btnTable2.Text += $"\nFood is ready";
        //    }
        //    else if (table2.Status == TableStatus.FoodIsServed)
        //    {
        //        btnTable2.Text += $"\nFood is served";
        //    }
        //}
        //public void ShowTable3()
        //{
        //    if (table3.Status == TableStatus.Free)
        //    {
        //        btnTable3.BackColor = Color.FromArgb(140, 236, 146);
        //        btnTable3.Text += $"\nAvailable";
        //    }
        //    else if (table3.Status == TableStatus.Occupied)
        //    {
        //        btnTable3.Text += $"\nOccupied";
        //    }
        //    else if (table3.Status == TableStatus.IsRunning)
        //    {
        //        btnTable3.Text += $"\nPreparing meal";
        //    }
        //    else if (table3.Status == TableStatus.FoodIsReady)
        //    {
        //        btnTable3.Text += $"\nFood is ready";
        //    }
        //    else if (table3.Status == TableStatus.FoodIsServed)
        //    {
        //        btnTable3.Text += $"\nFood is served";
        //    }
        //}
        //public void ShowTable4()
        //{
        //    if (table4.Status == TableStatus.Free)
        //    {
        //        btnTable4.BackColor = Color.FromArgb(140, 236, 146);
        //        btnTable4.Text += $"\nAvailable";
        //    }
        //    else if (table4.Status == TableStatus.Occupied)
        //    {
        //        btnTable4.Text += $"\nOccupied";
        //    }
        //    else if (table4.Status == TableStatus.IsRunning)
        //    {
        //        btnTable4.Text += $"\nPreparing meal";
        //    }
        //    else if (table4.Status == TableStatus.FoodIsReady)
        //    {
        //        btnTable4.Text += $"\nFood is ready";
        //    }
        //    else if (table4.Status == TableStatus.FoodIsServed)
        //    {
        //        btnTable4.Text += $"\nFood is served";
        //    }
        //}
        //public void ShowTable5()
        //{
        //    if (table5.Status == TableStatus.Free)
        //    {
        //        btnTable5.BackColor = Color.FromArgb(140, 236, 146);
        //        btnTable5.Text += $"\nAvailable";
        //    }
        //    else if (table5.Status == TableStatus.Occupied)
        //    {
        //        btnTable5.Text += $"\nOccupied";
        //    }
        //    else if (table5.Status == TableStatus.IsRunning)
        //    {
        //        btnTable5.Text += $"\nPreparing meal";
        //    }
        //    else if (table5.Status == TableStatus.FoodIsReady)
        //    {
        //        btnTable5.Text += $"\nFood is ready";
        //    }
        //    else if (table5.Status == TableStatus.FoodIsServed)
        //    {
        //        btnTable5.Text += $"\nFood is served";
        //    }
        //}
        //public void ShowTable6()
        //{
        //    if (table6.Status == TableStatus.Free)
        //    {
        //        btnTable6.BackColor = Color.FromArgb(140, 236, 146);
        //        btnTable6.Text += $"\nAvailable";
        //    }
        //    else if (table6.Status == TableStatus.Occupied)
        //    {
        //        btnTable6.Text += $"\nOccupied";
        //    }
        //    else if (table6.Status == TableStatus.IsRunning)
        //    {
        //        btnTable6.Text += $"\nPreparing meal";
        //    }
        //    else if (table6.Status == TableStatus.FoodIsReady)
        //    {
        //        btnTable6.Text += $"\nFood is ready";
        //    }
        //    else if (table6.Status == TableStatus.FoodIsServed)
        //    {
        //        btnTable6.Text += $"\nFood is served";
        //    }
        //}
        //public void ShowTable7()
        //{
        //    if (table7.Status == TableStatus.Free)
        //    {
        //        btnTable7.BackColor = Color.FromArgb(140, 236, 146);
        //        btnTable7.Text += $"\nAvailable";
        //    }
        //    else if (table7.Status == TableStatus.Occupied)
        //    {
        //        btnTable7.Text += $"\nOccupied";
        //    }
        //    else if (table7.Status == TableStatus.IsRunning)
        //    {
        //        btnTable7.Text += $"\nPreparing meal";
        //    }
        //    else if (table7.Status == TableStatus.FoodIsReady)
        //    {
        //        btnTable7.Text += $"\nFood is ready";
        //    }
        //    else if (table7.Status == TableStatus.FoodIsServed)
        //    {
        //        btnTable7.Text += $"\nFood is served";
        //    }
        //}
        //public void ShowTable8()
        //{
        //    if (table8.Status == TableStatus.Free)
        //    {
        //        btnTable8.BackColor = Color.FromArgb(140, 236, 146);
        //        btnTable8.Text += $"\nAvailable";
        //    }
        //    else if (table8.Status == TableStatus.Occupied)
        //    {
        //        btnTable8.Text += $"\nOccupied";
        //    }
        //    else if (table8.Status == TableStatus.IsRunning)
        //    {
        //        btnTable8.Text += $"\nPreparing meal";
        //    }
        //    else if (table8.Status == TableStatus.FoodIsReady)
        //    {
        //        btnTable8.Text += $"\nFood is ready";
        //    }
        //    else if (table8.Status == TableStatus.FoodIsServed)
        //    {
        //        btnTable8.Text += $"\nFood is served";
        //    }
        //}
        //public void ShowTable9()
        //{
        //    if (table9.Status == TableStatus.Free)
        //    {
        //        btnTable9.BackColor = Color.FromArgb(140, 236, 146);
        //        btnTable9.Text += $"\nAvailable";
        //    }
        //    else if (table9.Status == TableStatus.Occupied)
        //    {
        //        btnTable9.Text += $"\nOccupied";
        //    }
        //    else if (table9.Status == TableStatus.IsRunning)
        //    {
        //        btnTable9.Text += $"\nPreparing meal";
        //    }
        //    else if (table9.Status == TableStatus.FoodIsReady)
        //    {
        //        btnTable9.Text += $"\nFood is ready";
        //    }
        //    else if (table9.Status == TableStatus.FoodIsServed)
        //    {
        //        btnTable9.Text += $"\nFood is served";
        //    }
        //}
        //public void ShowTable10()
        //{
        //    if (table10.Status == TableStatus.Free)
        //    {
        //        btnTable10.BackColor = Color.FromArgb(140, 236, 146);
        //        btnTable10.Text += $"\nAvailable";
        //    }
        //    else if (table10.Status == TableStatus.Occupied)
        //    {
        //        btnTable10.Text += $"\nOccupied";
        //    }
        //    else if (table10.Status == TableStatus.IsRunning)
        //    {
        //        btnTable10.Text += $"\nPreparing meal";
        //    }
        //    else if (table10.Status == TableStatus.FoodIsReady)
        //    {
        //        btnTable10.Text += $"\nFood is ready";
        //    }
        //    else if (table10.Status == TableStatus.FoodIsServed)
        //    {
        //        btnTable10.Text += $"\nFood is served";
        //    }
        //}


        private void btnTable1_Click(object sender, EventArgs e)
        {
            TableOrder tableOrder = new TableOrder(tables[0], employee);
            tableOrder.Show();
            this.Hide();
            tableOrder.Closed += (s, args) => this.Close();
        }

        private void btnTable2_Click(object sender, EventArgs e)
        {
            TableOrder tableOrder = new TableOrder(tables[1], employee);
            tableOrder.Show();
            this.Hide();
            tableOrder.Closed += (s, args) => this.Close();
        }

        private void Overview_Load(object sender, EventArgs e)
        {

        }

        private void btnTable3_Click(object sender, EventArgs e)
        {
            TableOrder tableOrder = new TableOrder(tables[2], employee);
            tableOrder.Show();
            this.Hide();
            tableOrder.Closed += (s, args) => this.Close();
        }

        private void btnTable4_Click(object sender, EventArgs e)
        {
            TableOrder tableOrder = new TableOrder(tables[3], employee);
            tableOrder.Show();
            this.Hide();
            tableOrder.Closed += (s, args) => this.Close();
        }

        private void btnTable5_Click(object sender, EventArgs e)
        {
            TableOrder tableOrder = new TableOrder(tables[4], employee);
            tableOrder.Show();
            this.Hide();
            tableOrder.Closed += (s, args) => this.Close();
        }

        private void btnTable6_Click(object sender, EventArgs e)
        {
            TableOrder tableOrder = new TableOrder(tables[5], employee);
            tableOrder.Show();
            this.Hide();
            tableOrder.Closed += (s, args) => this.Close();
        }

        private void btnTable7_Click(object sender, EventArgs e)
        {
            TableOrder tableOrder = new TableOrder(tables[6], employee);
            tableOrder.Show();
            this.Hide();
            tableOrder.Closed += (s, args) => this.Close();
        }

        private void btnTable8_Click(object sender, EventArgs e)
        {
            TableOrder tableOrder = new TableOrder(tables[7], employee);
            tableOrder.Show();
            this.Hide();
            tableOrder.Closed += (s, args) => this.Close();
        }

        private void btnTable9_Click(object sender, EventArgs e)
        {
            TableOrder tableOrder = new TableOrder(tables[8], employee);
            tableOrder.Show();
            this.Hide();
            tableOrder.Closed += (s, args) => this.Close();
        }

        private void btnTable10_Click(object sender, EventArgs e)
        {
            TableOrder tableOrder = new TableOrder(tables[9], employee);
            tableOrder.Show();
            this.Hide();
            tableOrder.Closed += (s, args) => this.Close();
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
            login.Closed += (s, args) => this.Close();
        }
    }
}