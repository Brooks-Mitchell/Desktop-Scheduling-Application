using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969
{
    public class dbConnection
    {
       public static MySqlConnection sqlConnection { get; set; }
        
        public static void startConnection()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["localDB"].ConnectionString;

                sqlConnection = new MySqlConnection(connectionString);

                sqlConnection.Open();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public static void closeConnection()
        {
            try
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
                sqlConnection = null;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static DataTable dgvHelper(string sqlQuery)
        {
            MySqlCommand cmd = new MySqlCommand(sqlQuery, dbConnection.sqlConnection);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            return dt;
        }

        public static void ExecuteHelper(string nonQuery)
        {
  
            MySqlCommand cmd = new MySqlCommand(nonQuery, sqlConnection);
            cmd.ExecuteNonQuery();
        }


    }
}
