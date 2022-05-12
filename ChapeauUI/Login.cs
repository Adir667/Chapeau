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
using ChapeauLogic;
using ChapeauModel;

namespace ChapeauUI
{
    public partial class Login : Form
    {

        EmployeeService employeeService = new EmployeeService();

        public Login()
        {
            InitializeComponent();
            this.Text = "Chapeau Restaurant - Log in";
            lblDT.Text = DateTime.Now.ToString("HH:mm, dd/MM/yyyy");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserID.Text == "" || txtPincode.Text == "")
                {
                    MessageBox.Show("Please fill in both UserID and Pincode (digits only)", "Log in failed");
                    return;
                }

                // if username exsists
                Employee employee = employeeService.GetEmployeesCredentials(txtUserID.Text, txtPincode.Text);
                if (employee == null)
                {
                    MessageBox.Show("Login credentials incorrect, check ID again or contact administrator", "Log in failed");
                    return;
                }
                else
                {
                        if (employee.Position == JobPosition.Waiter || employee.Position == JobPosition.Owner)
                        {
                            Overview overview = new Overview(employee);
                            overview.Show();
                            this.Hide();
                            overview.Closed += (s, args) => this.Close();
                        }
                        else if (employee.Position == JobPosition.Bartender || (employee.Position == JobPosition.Chef))
                        {
                            KitchenBar kitchenBar = new KitchenBar(employee);
                            kitchenBar.Show();
                            this.Hide();
                            kitchenBar.Closed += (s, args) => this.Close();
                        }
                }
            }
            catch (Exception ex)
            {
                ErrorProcess(ex, "Something went wrong while loging in");
            }
        }

        private void ErrorProcess(Exception ex, string messege)
        {
            MessageBox.Show(messege, "Error occured");
            // write to error log file
            StreamWriter sw = File.AppendText("..\\..\\..\\Error Log.txt");
            sw.WriteLine(messege);
            Console.WriteLine(ex);
            Console.WriteLine();
            sw.Close();
        }
    }
}

