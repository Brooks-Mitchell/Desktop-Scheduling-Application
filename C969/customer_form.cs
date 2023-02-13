using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace C969
{
    public partial class customer_form : Form
    {
        public customer_form()
        {
            InitializeComponent();

            customerDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customerDGV.DataSource = dbConnection.dgvHelper("select customerName AS 'Customer Name', city.city, country.country, address.phone, customerId as 'Cust. #' from customer JOIN address ON customer.addressId = address.addressId JOIN city ON address.cityId = city.cityId JOIN country ON city.countryId = country.countryId; ");

            customerDGV.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(customerDGV_DataBindingComplete);
            custIdTextBox.Enabled = false;

            disableTextBox();
            defaultBtns();

            // gets the last ID inserted into database, assigns it to customerIncrement
            Customer.getLast();
            Customer.customerIncrement++;

        }
        // LOADING AND UI BUTTONS
        private void customerDGV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            customerDGV.ClearSelection();
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            report_form report_form = new report_form();
            report_form.Show();
        }

        private void customerPic_Click(object sender, EventArgs e)
        {
            this.Hide();
            report_form report_form = new report_form();
            report_form.Show();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            home home = new home();
            home.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            home home = new home();
            home.Show();
        }

        private void customerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentIndex = customerDGV.CurrentCell.RowIndex;

            // puts the cell clicked into the text boxes for editing
            custNameText.Text = (string)customerDGV.Rows[currentIndex].Cells[0].Value.ToString();
            custCityText.Text = (string)customerDGV.Rows[currentIndex].Cells[1].Value.ToString();
            custCountryText.Text = (string)customerDGV.Rows[currentIndex].Cells[2].Value.ToString();
            custPhoneText.Text = (string)customerDGV.Rows[currentIndex].Cells[3].Value.ToString();
            custIdTextBox.Text = (string)customerDGV.Rows[currentIndex].Cells[4].Value.ToString();

            Customer.CustomerID = (int)customerDGV.Rows[currentIndex].Cells[4].Value;
            
            editBtn.Enabled = true;
            deleteBtn.Enabled = true;
            cancelBtn.Enabled = true;

            disableTextBox();
        }

        // FORM BUTTONS
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete this customer?", "Delete - Customer", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try 
                { 
                    Customer.deleteCustomer(Customer.CustomerID);
                    customerDGV.DataSource = dbConnection.dgvHelper("select customerName AS 'Customer Name', city.city, country.country, address.phone, customerId as 'Cust. #' from customer JOIN address ON customer.addressId = address.addressId JOIN city ON address.cityId = city.cityId JOIN country ON city.countryId = country.countryId; ");
                    clearFields();
                    defaultBtns();
                }
                catch
                {
                    MessageBox.Show("Cannot delete a customer with a scheduled appointment.");
                }
            }
        }


        private void saveBtn_Click(object sender, EventArgs e)
        {

            int currentIndex = customerDGV.CurrentCell.RowIndex;


            Customer customer = new Customer(
                custNameText.Text,
                custCityText.Text,
                custCountryText.Text,
                custPhoneText.Text
                );


            if (Customer.addingNew == true)
            {
                Customer.getLast();
                Customer.CustomerID = Customer.customerIncrement;
                Customer.addNewCustomer(customer); 
            }
            else
            {
                Customer.CustomerID = (int)customerDGV.Rows[currentIndex].Cells[4].Value;
                Customer.editCustomer(customer); 
            }
            
            customerDGV.DataSource = dbConnection.dgvHelper("select customerName AS 'Customer Name', city.city, country.country, address.phone, customerId as 'Cust. #' from customer JOIN address ON customer.addressId = address.addressId JOIN city ON address.cityId = city.cityId JOIN country ON city.countryId = country.countryId; ");
            clearFields();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            customerDGV.ClearSelection();
            clearFields();
            disableTextBox();
            editBtn.Enabled = false;
            deleteBtn.Enabled = false;
            Customer.addingNew = false;
        }


        private void editBtn_Click(object sender, EventArgs e)
        {
            enableTextBox();
            Customer.addingNew = false;
        }

        private void addNewBtn_Click(object sender, EventArgs e)
        {
            Customer.addingNew = true;
            customerDGV.ClearSelection();
            clearFields();

            cancelBtn.Enabled = true;
            editBtn.Enabled = false;
            deleteBtn.Enabled = false;

            enableTextBox();

        }

        // FORM VALIDATION

        private bool allowSave()
        {

            return
                (!string.IsNullOrWhiteSpace(custNameText.Text)) && (!string.IsNullOrWhiteSpace(custPhoneText.Text) &&
                (!string.IsNullOrWhiteSpace(custCityText.Text)) && (!string.IsNullOrWhiteSpace(custCountryText.Text)));
        }

        public void toolTipHelper(TextBox field, string message)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.ShowAlways = true;
            toolTip.InitialDelay = 1;

            toolTip.SetToolTip(field, message);
        }

        private void inputCheck(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                toolTipHelper(textBox, "Cannot be empty");
                saveBtn.Enabled = false;
            }
            else
            {
                saveBtn.Enabled = allowSave();
            }
            allowSave();
            
        }


        private void custNameText_TextChanged(object sender, EventArgs e)
        {
            inputCheck(custNameText);
        }

        private void custCityText_TextChanged(object sender, EventArgs e)
        {
            inputCheck(custCityText);
        }

        private void custCountryText_TextChanged(object sender, EventArgs e)
        {
            inputCheck(custCountryText);
        }

        private void custPhoneText_TextChanged(object sender, EventArgs e)
        {
            inputCheck(custPhoneText);
        }

        // HELPERS
        public void clearFields()
        {
            custNameText.Clear();
            custPhoneText.Clear();
            custCityText.Clear();
            custCountryText.Clear();
            custIdTextBox.Clear();
        }

        private void disableTextBox()
        {
            custNameText.Enabled = false;
            custPhoneText.Enabled = false;
            custCityText.Enabled = false;
            custCountryText.Enabled = false;
        }

        private void enableTextBox()
        {
            custNameText.Enabled = true;
            custPhoneText.Enabled = true;
            custCityText.Enabled = true;
            custCountryText.Enabled = true;
        }

        private void enableAllBtn()
        {
            deleteBtn.Enabled = true;
            editBtn.Enabled = true;
            saveBtn.Enabled = true;
            cancelBtn.Enabled = true;
        }

        private void defaultBtns()
        {
            editBtn.Enabled = false;
            deleteBtn.Enabled = false;
            cancelBtn.Enabled = false;
            saveBtn.Enabled = false;
        }

        
    }
}
