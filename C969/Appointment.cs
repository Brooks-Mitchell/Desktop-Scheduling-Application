using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969
{
    public static class Appointment
    {

        public static int AppointmentIncrement { get; set; }
        public static bool EditingApt { get; set; } = false;

        public static int CustomerID { get; set; }
        public static string CustomerName { get; set; }
        public static int AptID { get; set; }
        public static string AptType {  get; set; }
        
 
        // time
        public static DateTime AptStartTime { get; set; } = new DateTime();
        public static DateTime AptEndTime { get; set; } = new DateTime();
        private static int BusinessStartTime { get; set; } = 8;
        private static int BusinessEndTime { get; set; } = 18;

        

        public static void getLastIndex()
        {
            MySqlConnection conn = dbConnection.sqlConnection;
            MySqlCommand cmd = new MySqlCommand("SELECT MAX(appointmentId) FROM appointment; ", conn);
            AppointmentIncrement = (int)cmd.ExecuteScalar();
            AppointmentIncrement++;
        }

        public static void AddAppointment()
        {
            string StartFormat  = AptStartTime.ToString("yyyy-MM-dd HH:mm:ss");
            string EndFormat  = AptEndTime.ToString("yyyy-MM-dd HH:mm:ss");

            dbConnection.ExecuteHelper("INSERT INTO appointment VALUES(' " + AppointmentIncrement + "', '" + Customer.CustomerID + "', '" + User.userID + "', 'title', 'desc', 'aLocation', 'aContact', '" + AptType + "', 'aURL', ' " + StartFormat + "', ' " + EndFormat + "', '2022-12-16 16:50:00', 'test', '2022-12-10 16:50:00', 'test')");
        }

        public static void DeleteAppointment()
        {
           
           dbConnection.ExecuteHelper("DELETE FROM appointment WHERE appointmentId = '" + AptID +"'");
        }

        public static void EditAppointment()
        {
            string StartFormat = AptStartTime.ToString("yyyy-MM-dd HH:mm:ss");
            string EndFormat = AptEndTime.ToString("yyyy-MM-dd HH:mm:ss");
            dbConnection.ExecuteHelper("UPDATE appointment SET type =  '" + AptType + "', start =  '" + StartFormat + "', end = '" + EndFormat + "' WHERE appointmentId = '" + AptID + "'");
           
        }

        public static bool OverlapCheck()
        {
            string StartFormat = AptStartTime.ToString("yyyy-MM-dd HH:mm:ss");
            string EndFormat = AptEndTime.ToString("yyyy-MM-dd HH:mm:ss");
            
            DataTable currentTime = dbConnection.dgvHelper("SELECT start, end FROM appointment WHERE userId = '" + User.userID + "' AND start BETWEEN '" + StartFormat + "' AND '" + EndFormat + "' OR end BETWEEN '" + StartFormat + "' AND '" + EndFormat + "'");


            if (currentTime.Rows.Count > 0)
            {
                return false;
            }
            else return true;
        }

        public static bool BizHoursCheck()
        {
            return ((AptStartTime.Hour > BusinessStartTime) && (AptStartTime.Hour < BusinessEndTime));
 
        }

        public static void AptCheck()
        {
            MySqlConnection conn = dbConnection.sqlConnection;
            MySqlCommand timeCheck = new MySqlCommand("select * from appointment where userId = '" + User.userID + "' AND start < date_add(NOW(), INTERVAL 15 MINUTE) AND start >=NOW();", conn);
            var result = (int?)timeCheck.ExecuteScalar();
            if (result != null)
            {
                MessageBox.Show("You have an appointment within 15 minutes!");
            }
        }

        public static void GetCustomerFromCombo(string userNameText)
        {
            MySqlConnection conn = dbConnection.sqlConnection;
            MySqlCommand cmd = new MySqlCommand("SELECT customerId FROM customer WHERE customerName = '" + userNameText + "'", conn);
            // TOTDO - fix: Throws a non-crashing error when combo box becomes empty
            Customer.CustomerID = (int)cmd.ExecuteScalar();
        }

    }
}
