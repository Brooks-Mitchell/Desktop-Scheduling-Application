using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// TEMP XXX
using System.Windows.Forms;

namespace C969
{


    public class Customer
    {
        public static int customerIncrement { get; set; }
        public static int CustomerID { get; set; }
        public static bool addingNew { get; set; } = false;

        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerCountry { get; set; }
        
        public Customer(string name, string city, string country, string phone)
        {
            CustomerName = name;
            CustomerCity = city;
            CustomerCountry = country;
            CustomerPhone = phone;
        }


        public static void deleteCustomer(int customerId)
        {
            dbConnection.ExecuteHelper("DELETE FROM customer WHERE customerId = '" + CustomerID + "'");
            dbConnection.ExecuteHelper("DELETE FROM address WHERE addressId = '" + CustomerID + "'");
            dbConnection.ExecuteHelper("DELETE FROM city WHERE cityId = '" + CustomerID + "'");
            dbConnection.ExecuteHelper("DELETE FROM country WHERE countryId = '" + CustomerID + "'");

        }

        public static void getLast()
        {
            MySqlConnection conn = dbConnection.sqlConnection;
            MySqlCommand cmd = new MySqlCommand("SELECT MAX(customerId) FROM customer; ", conn);
            customerIncrement = (int)cmd.ExecuteScalar();
            customerIncrement++;
        }



        // this adds the country, then city, then address before a new customer is created and tied to new 1-1-1 entries.
        // uses dummy data for non-null fields that can't be altered to have defaults
        public static void addAddress(string country, string city, string phone)
        {
            dbConnection.ExecuteHelper("INSERT INTO country VALUES(' " + customerIncrement + "', '" + country + "', '2022-12-10 16:50:00', 'test', '2022-12-10 16:50:00', 'test' )");

            dbConnection.ExecuteHelper("INSERT INTO city VALUES(' " + customerIncrement + "', '" + city + "', ' " + customerIncrement + "', '2022-12-10 16:50:00', 'test', '2022-12-10 16:50:00', 'test')");

            dbConnection.ExecuteHelper("INSERT INTO address VALUES(' " + customerIncrement + "', '123 Main',  'mailbox ', ' " + customerIncrement + "', '11111', '" + phone + "', '2022-12-10 16:50:00', 'test', '2022-12-10 16:50:00', 'test' )");
        }

        // modify exiting customer
        public static void editCustomer(Customer customer)
        {
            addAddress(customer.CustomerCountry, customer.CustomerCity, customer.CustomerPhone);

            dbConnection.ExecuteHelper("UPDATE customer SET customerId = '" + CustomerID + "', customerName = '" + customer.CustomerName + "', addressId = '" + customerIncrement + "', active = 1, createDate = '2022-12-10 16:50:00', createdBy = 'test', lastUpdate =  '2022-12-10 16:50:00', lastUpdateBy = 'test' WHERE customerId = '" + CustomerID + "'");

           customerIncrement ++;

        }

        public static void addNewCustomer(Customer customer)
        {
            addAddress(customer.CustomerCountry, customer.CustomerCity, customer.CustomerPhone);

            dbConnection.ExecuteHelper("INSERT INTO customer VALUES(' " + customerIncrement + "', ' " + customer.CustomerName + " ',  ' " + customerIncrement + "', 1, '2022-12-10 16:50:00', 'test', '2022-12-10 16:50:00', 'test' )");

            customerIncrement++;


        }
    }
}
