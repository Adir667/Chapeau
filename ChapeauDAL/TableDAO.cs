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
    public class TableDAO : BaseDAO
    {
        public Table GetTable(int tableNr)
        {
            try
            {
                string query = "SELECT table_id, table_nr, [status] " +
                                "FROM [TABLE] " +
                                "WHERE table_nr = @TableNr;";
                SqlParameter[] sqlParameters =
                {
                new SqlParameter("TableNr", tableNr),
                };
                return ReadTable(ExecuteSelectQuery(query, sqlParameters));
            }
            catch (Exception ex)
            {
                WriteToErrorLog(ex.ToString());
                return null;
            }
        }
        private Table ReadTable(DataTable dataTable)
        {
            Table table = new Table();
            foreach (DataRow dr in dataTable.Rows)
            {
                {
                    table.TableID = (int)dr["table_id"];
                    table.TableNr = (int)dr["table_nr"];
                    table.Status = (TableStatus)(int)dr["status"];
                };
            }
            return table;
        }


        public void UpdateStatus(Table table)
        {
            string query = "UPDATE [TABLE] SET [status] = @Status WHERE table_id = @TableID";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("Status", (int)(table.Status)),
                new SqlParameter("TableID", (table.TableID)),

            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void FoodIsReady(Table table)
        {
            string query = "UPDATE [TABLE] SET [status] = 2 WHERE table_id = @TableID";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("TableID", (table.TableNr)),
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public List<Table> GetAllTables()
        {
            try
            {
                string query = "SELECT table_id, table_nr, [status] " +
                                "FROM [TABLE];";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                return ReadTables(ExecuteSelectQuery(query, sqlParameters));
            }
            catch (Exception ex)
            {
                WriteToErrorLog(ex.ToString());
                return null;
            }
        }
        private List<Table> ReadTables(DataTable dataTable)
        {
            List<Table> tables = new List<Table>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Table table = new Table();
                {
                    table.TableID = (int)dr["table_id"];
                    table.TableNr = (int)dr["table_nr"];
                    table.Status = (TableStatus)(int)dr["status"];
                };
                tables.Add(table);
            }
            return tables;
        }


    }
}
