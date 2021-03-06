using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauDAL
{
    public class OrderDAO : BaseDAO
    {
        public List<Order> GetOrders(bool drinks, bool history)
        {
            try
            {
                string query = "SELECT DISTINCT(O.order_id), T.table_nr, O.[timeStamp], category_id, first_name, last_name " +
                               "FROM [ORDER] AS O " +
                               "JOIN [TABLE] AS T ON O.table_id = T.table_id " +
                               "JOIN EMPLOYEE AS E ON O.employee_id = E.employee_id " +
                               "JOIN ORDERITEM AS OI ON O.order_id = OI.order_id " +
                               "JOIN MENUITEM AS MI ON OI.item_id = MI.item_id " +
                               "WHERE OI.[status] ";
                                query += (history ? "> 0 " : "= 0 ");
                                query += "AND MI.category_id ";
                                query += (drinks ? "> 30 " : "< 30 ");
                                query += "ORDER BY O.[timeStamp]";
                                query += (history ? "DESC; " : "; ");


                SqlParameter[] sqlParameters = new SqlParameter[0];
                return ReadOrders(ExecuteSelectQuery(query, sqlParameters));
            }
            catch (Exception ex)
            {
                WriteToErrorLog(ex.ToString());
                return null;
            }

        }

        private List<Order> ReadOrders(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order();
                order.Table = new Table();
                order.Employee = new Employee();
                {
                    order.OrderID = (int)dr["order_id"];
                    order.Table.TableNr = (int)dr["table_nr"];
                    order.TimeStamp = (DateTime)dr["timeStamp"];
                    order.Employee.FirstName = (string)dr["first_name"];
                    order.Employee.LastName = (string)dr["last_name"];
                };
                orders.Add(order);
            }
            return orders;
        }

        public List<OrderItem> GetItems(Order order, bool drinks, bool history)
        {
            string query = "SELECT [name], amount, [timeStamp], [status], remark, MI.item_id " +
                "FROM ORDERITEM AS OI " +
                "JOIN MENUITEM AS MI ON OI.item_id = MI.item_id " +
                "WHERE order_id = @ID AND MI.category_id ";
                 query += (drinks ? "> 30 " : "< 30 ");
                 query += "AND [status] ";
                 query += (history ? "> 0 " : "= 0 ");
                 query += "ORDER BY [status], OI.[timeStamp]; ";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("ID", order.OrderID),
            };
            return ReadOrderItem(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<OrderItem> ReadOrderItem(DataTable dataTable)
        {
            List<OrderItem> OrderItems = new List<OrderItem>();
            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem orderItem = new OrderItem();
                orderItem.Item = new MenuItem();
                {
                    orderItem.Item.Name = (string)dr["name"];
                    orderItem.Amount = (int)dr["amount"];
                    orderItem.TimeStamp = (DateTime)dr["timeStamp"];
                    orderItem.Status = (OrderItemStatus)((int)dr["status"]);
                    orderItem.Remark = (string)dr["remark"].ToString();
                    orderItem.Item.ItemID = (int)dr["item_id"];
                };
                OrderItems.Add(orderItem);
            }
            return OrderItems;
        }

        public void UpdateStatus(OrderItem orderItem, Order order)
        {
            string query = "UPDATE ORDERITEM SET [status] = @Status WHERE order_id = @OrderID AND item_id = @ItemID AND [timeStamp] = @TimeStamp;";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("Status", (int)(orderItem.Status)),
                new SqlParameter("OrderID", order.OrderID),
                new SqlParameter("ItemID", orderItem.Item.ItemID),
                new SqlParameter("TimeStamp", orderItem.TimeStamp),
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateOrder(Order order, OrderItem orderItem)
        {
            string query = "INSERT INTO ORDERITEM (order_id, item_id, amount, timeStamp, status, remark) " +
                                          "VALUES( @OrderID, @ItemID, @Amount, @Time, @Status, @Remark)";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@OrderID", order.OrderID),
                new SqlParameter("@ItemID", orderItem.Item.ItemID),
                new SqlParameter("@Amount", orderItem.Amount),
                new SqlParameter("@Time", DateTime.Now),
                new SqlParameter("@Status", orderItem.Status),
                new SqlParameter("@remark", orderItem.Remark),
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public int GenerateOrderNr()
        {
            string query = "SELECT MAX(order_id) AS result FROM[ORDER];";
                SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadCountData(ExecuteSelectQuery(query, sqlParameters)) +1;
        }

        public void CreateOrderItems(Order order)
        {
            string query = "INSERT INTO [ORDER] (order_id, table_id, employee_id, [timeStamp], paid) " +
                           "VALUES(@OrderID, @TableID, @EmployeeID, @TimeStamp, 0)";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("OrderID", order.OrderID),
                new SqlParameter("TableID", order.Table.TableID),
                new SqlParameter("EmployeeID", order.Employee.EmployeeID),
                new SqlParameter("TimeStamp", DateTime.Now),
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public List<OrderItem> GetRunningOrder(Order order)
        {
            string query = "SELECT [name], amount, [timeStamp], [status], remark, MI.item_id " +
                "FROM ORDERITEM AS OI " +
                "JOIN MENUITEM AS MI ON OI.item_id = MI.item_id " +
                "WHERE order_id = @OrderID";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("OrderID", order.OrderID),
            };
            return ReadOrderItem(ExecuteSelectQuery(query, sqlParameters));
        }

        public Order GetByTable(Table table)
        {
            string query = "SELECT order_id " +
                "FROM [ORDER] " +
                "WHERE table_id = @TableID;";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("TableID", table.TableID),
            };
            return ReadOrder(ExecuteSelectQuery(query, sqlParameters));
        }
        private Order ReadOrder(DataTable dataTable)
        {
            Order order = new Order();
            foreach (DataRow dr in dataTable.Rows)
            {
                {
                    order.OrderID = (int)dr["order_id"];
                };
            }
            return order;
        }



    }
}
