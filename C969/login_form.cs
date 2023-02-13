using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.IO;
using MySql.Data.MySqlClient;

namespace C969
{
    public partial class login_form : Form
    {

        bool foreign = false;

        public login_form()
        {

            CultureInfo current = CultureInfo.CurrentCulture;

            CultureInfo newCulture;

            if (current.Name.Equals("nl-NL"))
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("nl-NL");
                foreign = true;
            }

            else
                newCulture = new CultureInfo("en-US");

            InitializeComponent();
        }

        // appends login time and username to log.txt
        public static void log(string log_text)
        {

            string path = @"log.txt";
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(log_text);
            }
            using (StreamReader strRead = File.OpenText(path))
            {
                string stream = "";
                while ((stream = strRead.ReadLine()) != null)
                {
                    Console.WriteLine(stream);
                }
            }
        }


        private void login_btn_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection conn = dbConnection.sqlConnection;

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM user where userName = '" + username_field.Text + "' AND password = '" + password_field.Text + "'", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    
                    MySqlConnection conn2 = dbConnection.sqlConnection;
                    MySqlCommand cmd2 = new MySqlCommand("SELECT userId FROM user where userName = '" + username_field.Text + "' AND password = '" + password_field.Text + "'", conn);
                    int userID = (int)cmd2.ExecuteScalar();

                    User.userID = userID;
                    User.userName = username_field.Text;

                    string log_text = username_field.Text + " " + DateTime.UtcNow.ToString();
                    log(log_text);

                    this.Hide();
                    home home = new home();
                    home.Show();
                }

            }
            catch (Exception ex)
            {
                    MessageBox.Show("Incorrect Username or password");
            }
        }
    }
}
