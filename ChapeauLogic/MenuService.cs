using ChapeauDAL;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauLogic
{
    public class MenuService
    {
        MenuDAO menudb;

        public MenuService()
        {
            menudb = new MenuDAO();
        }

        public List<MenuCategory> GetLunch()
        {
            return menudb.GetLunch();
        }

        public List<MenuCategory> GetDinner()
        {
            return menudb.GetDinner();
        }

        public List<MenuCategory> GetDrinks()
        {
            return menudb.GetDrinks();
        }

        public List<MenuItem> GetMenuItem(MenuCategory categoryId)
        {
            return menudb.GetMenuItems(categoryId);
        }

        public void UpdateStock(MenuItem item)
        {
            menudb.UpdateStock(item);
        }
    }
}
