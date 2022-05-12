using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
 using ChapeauModel;
using System.Configuration;
using System.Collections.Generic;

namespace ChapeauDAL
{
    public class EmployeeDAO : BaseDAO
    {
        public Employee GetByID(int id)
        {
            string query = "SELECT employee_id, first_name, last_name, position, pincode " +
                "FROM EMPLOYEE " +
                "WHERE employee_id = @ID; ";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("ID", id),
                };
            return ReadEmployee(ExecuteSelectQuery(query, sqlParameters));
        }

        private Employee ReadEmployee(DataTable dataTable)
        {
            if (dataTable == null)
            {
                return null;
            }
            Employee employee = new Employee();

            foreach (DataRow dr in dataTable.Rows)
            {
                {
                    employee.EmployeeID = (int)dr["employee_id"];
                    employee.FirstName = (string)(dr["first_name"].ToString());
                    employee.LastName = (string)dr["last_name"];
                    employee.Position = (JobPosition)(int)dr["position"];
                    employee.Pincode = (int)dr["pincode"];
                };
            }
            return employee;
        }

        public int CheckExistingEmployee(int id)
        {
            string query = "SELECT COUNT (employee_id) AS [result] FROM EMPLOYEE WHERE employee_id = @ID";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@ID", id),
                };
            return ReadCountData(ExecuteSelectQuery(query, sqlParameters));
        }
        public Employee GetAccount(string employeeId, string pincode) //get an account matching the parameters
        {
            conn.Open();

            String query = "select employee_id,first_name, last_name, position, [pincode] FROM EMPLOYEE where employee_id = @employee_id AND [pincode] = @pincode COLLATE Latin1_General_CS_AS;";
            SqlParameter[] parameters =
             {
                new SqlParameter("@employee_id", employeeId),
                new SqlParameter("@pincode", pincode),
                };
            conn.Close();


            return ReadEmployee(ExecuteSelectQuery(query, parameters));//not working
        }
    }
}

