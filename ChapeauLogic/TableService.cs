using ChapeauDAL;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauLogic
{
    public class TableService
    {
        TableDAO tabledb;

        public TableService()
        {
            tabledb = new TableDAO();
        }

        public Table GetTable(int tableNr)
        {
            return tabledb.GetTable(tableNr);
        }

        public void UpdateStatus(Table table)
        {
            tabledb.UpdateStatus(table);
        }

        public void FoodIsReady(Table table)
        {
            tabledb.FoodIsReady(table);
        }

        public List<Table> GetAllTables()
        {
            return tabledb.GetAllTables();
        }


    }
}
