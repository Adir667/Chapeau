using ChapeauDAL;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauLogic
{
    public class OrderService
    {
        OrderDAO orderdb;

        public OrderService()
        {
            orderdb = new OrderDAO();
        }

        public List<Order> GetOrders(bool drinks, bool history)
        {
            return orderdb.GetOrders(drinks, history);
        }

        public List<OrderItem> GetItems(Order order, bool drinks, bool history)
        {
            return orderdb.GetItems(order, drinks, history);
        }

        public void UpdateStatus(OrderItem orderItem, Order order)
        {
            orderdb.UpdateStatus(orderItem, order);
        }

        public void UpdateOrder(Order order, OrderItem orderItem)
        {
            orderdb.UpdateOrder(order, orderItem);
        }

        public int GenerateOrderNr()
        {
            return orderdb.GenerateOrderNr();
        }

        public void CreateOrderItems(Order order)
        {
            orderdb.CreateOrderItems(order);
        }

        public void RemoveItems()
        {
            //...
        }

        public Order GetByTable(Table table)
        {
            return orderdb.GetByTable(table);
        }

        public List<OrderItem> GetRunningOrder(Order order)
        {
            return orderdb.GetRunningOrder(order);
        }
    }
}
