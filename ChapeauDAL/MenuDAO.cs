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
    public class MenuDAO : BaseDAO
    {

        public List<MenuCategory> GetLunch()
        {
            string query = "SELECT category_id, category_name " +
                           "FROM MENUCATEGORY " +
                           "WHERE category_id < 20 ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadCategory(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<MenuCategory> GetDinner()
        {
            string query = "SELECT category_id, category_name " +
                           "FROM MENUCATEGORY " +
                           "WHERE category_id > 20 AND category_id < 30 ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadCategory(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<MenuCategory> GetDrinks()
        {
            string query = "SELECT category_id, category_name " +
                           "FROM MENUCATEGORY " +
                           "WHERE category_id > 30 AND category_id < 40 ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadCategory(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<MenuCategory> ReadCategory(DataTable dataTable)
        {
            List<MenuCategory> categories = new List<MenuCategory>();
            foreach (DataRow dr in dataTable.Rows)
            {
                MenuCategory category = new MenuCategory();
                {
                    category.Name = (string)dr["category_name"];
                    category.CategoryID = (int)dr["category_id"];
                };
                categories.Add(category);
            }
            return categories;
        }

        public List<MenuItem> GetMenuItems(MenuCategory categoryId)
        {
            string query = "SELECT item_id, [name], price, stock, vat " +
                           "FROM MENUITEM " +
                           "WHERE category_id =@categoryID;";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("categoryID", categoryId.CategoryID),
                };
            return ReadMenuItem(ExecuteSelectQuery(query, sqlParameters));

        }

        private List<MenuItem> ReadMenuItem(DataTable dataTable)
        {
            List<MenuItem> items = new List<MenuItem>();
            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem item = new MenuItem();
                {
                    item.Name = (string)dr["name"];
                    item.ItemID = (int)dr["item_id"];
                    item.Stock = (int)dr["stock"];
                    item.Vat = (double)dr["vat"];
                    item.Price = (double)dr["price"];
                };
                items.Add(item);
            }
            return items;
        }

        public void UpdateStock(MenuItem item)
        {
            string query = "UPDATE MENUITEM SET stock = @Stock WHERE item_id = @ItemID;";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("Stock", (item.Stock)),
                new SqlParameter("ItemID", item.ItemID),
            };
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
