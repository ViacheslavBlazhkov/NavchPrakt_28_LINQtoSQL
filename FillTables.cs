using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace NavchPrakt_28_LINQtoSQL
{
    public class FillTables
    {
        public void FillTable(string query, MySqlConnection conn, DataGridView DTV)
        {
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);
            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);

            DTV.Columns.Clear();
            DTV.DataSource = dataSet.Tables[0];
        }
    }
}
