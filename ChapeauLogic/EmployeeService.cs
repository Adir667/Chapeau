using ChapeauDAL;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauLogic
{
    public class EmployeeService
    {
        EmployeeDAO employeedb;
        private EmployeeDAO employee_dao = new EmployeeDAO();

        public EmployeeService()
        {
            employeedb = new EmployeeDAO();
        }

        public int CheckExistingEmployee(int id)
        {
            return employeedb.CheckExistingEmployee(id);
        }
        public Employee GetByID(int id)
        {
            return employeedb.GetByID(id);
        }
        public Employee GetEmployeesCredentials(string employeeId, string pincode)
        {
            return employee_dao.GetAccount(employeeId, pincode);
        }
    }
}
