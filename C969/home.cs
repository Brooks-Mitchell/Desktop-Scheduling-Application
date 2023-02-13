using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969
{
    public partial class home : Form
    {

        public home()
        {
            InitializeComponent();

            hello_user.Text = $"Logged in as: {User.userName}";
            displayUserTime.Text = User.getUserTime().ToString();
            calendarDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            Appointment.AptCheck();

            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            endTimePicker.Format = DateTimePickerFormat.Custom;
            endTimePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";

            //Calendar Views
            string[] ranges = { "All", "Week", "Month" };
            dateComboBox.Items.AddRange(ranges);
            dateComboBox.SelectedIndex = 0;

            //populate customer namebox
            DataTable custDT = dbConnection.dgvHelper("SELECT customerName FROM customer");

            // LAMBDA EXPRESSION: converts DataTable object into an array to populate nameBox ComboBox
            string[] custArray = custDT.Rows.OfType<DataRow>().Select(x => x[0].ToString()).ToArray();
            nameBox.Items.AddRange(custArray);

            //populate appointment type combobox
            DataTable aptDT = dbConnection.dgvHelper("SELECT type FROM appointment");

            // LAMBDA EXPRESSION: converts DataTable object into an array to populate appointment types ComboBox 
            // these two lamda expression implement closures so that local state is passed to the function without adding parameters and
            // removes the need to create a separate function
            string[] aptArray = aptDT.Rows.OfType<DataRow>().Select(x => x[0].ToString()).ToArray();
            aptTypeField.Items.AddRange(aptArray);


            DefaultBtns();
            saveBtn.Enabled = allowSave();
            DisableForm();

            // for UTC to local time
            calendarDGV.CellFormatting +=
            new DataGridViewCellFormattingEventHandler(
            this.calendarDGV_CellFormatting);
        }

        
        private void calendarDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is DateTime)
            {
                e.Value = ((DateTime)e.Value).ToLocalTime();
            }
        }


        private void calendarDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentIndex = calendarDGV.CurrentCell.RowIndex;


            Appointment.CustomerName = (string)calendarDGV.Rows[currentIndex].Cells[0].Value.ToString();
            Appointment.AptType = (string)calendarDGV.Rows[currentIndex].Cells[1].Value.ToString();
            Appointment.AptStartTime = (DateTime)calendarDGV.Rows[currentIndex].Cells[2].Value;
            Appointment.AptEndTime = (DateTime)calendarDGV.Rows[currentIndex].Cells[3].Value;

            Appointment.CustomerID = (int)calendarDGV.Rows[currentIndex].Cells[5].Value;
            Appointment.AptID = (int)calendarDGV.Rows[currentIndex].Cells[6].Value;

            nameBox.Text = (string)calendarDGV.Rows[currentIndex].Cells[0].Value.ToString();
            aptTypeField.Text = (string)calendarDGV.Rows[currentIndex].Cells[1].Value.ToString();

            dateTimePicker.Value = Appointment.AptStartTime.ToLocalTime();
            endTimePicker.Value = Appointment.AptEndTime.ToLocalTime();

            saveBtn.Enabled = false;
            editBtn.Enabled = true;
            deleteBtn.Enabled = true;
            EnableForms();
        }

        private void dateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dateComboBox.SelectedIndex == 0)
            {
                calendarDGV.DataSource = dbConnection.dgvHelper("SELECT customer.customerName AS Name, appointment.type, start, end, phone AS contact, customer.customerId, appointmentId FROM appointment JOIN customer ON appointment.customerId = customer.customerId JOIN address ON address.addressId = customer.addressId WHERE appointment.userId = '" + User.userID + "' ORDER BY start desc");
                calendarDGV.Columns[calendarDGV.Columns.Count - 1].Visible = false;
                calendarDGV.Columns[calendarDGV.Columns.Count - 2].Visible = false;
            }

            if (dateComboBox.SelectedIndex == 1)
            {
                calendarDGV.DataSource = dbConnection.dgvHelper("SELECT customer.customerName AS Name, appointment.type, start, end, phone AS contact, customer.customerId AS ID FROM appointment JOIN customer ON appointment.customerId = customer.customerId JOIN address ON address.addressId = customer.addressId WHERE appointment.userId = '" + User.userID + "' AND start BETWEEN CURRENT_DATE() AND DATE_ADD(CURRENT_DATE(), INTERVAL 1 WEEK) ORDER BY start desc");
                calendarDGV.Columns[calendarDGV.Columns.Count - 1].Visible = false;
                calendarDGV.Columns[calendarDGV.Columns.Count - 2].Visible = false;
            }

            if (dateComboBox.SelectedIndex == 2)
            {
                calendarDGV.DataSource = dbConnection.dgvHelper("SELECT customer.customerName AS Name, appointment.type, start, end, phone AS contact, customer.customerId AS ID FROM appointment JOIN customer ON appointment.customerId = customer.customerId JOIN address ON address.addressId = customer.addressId WHERE appointment.userId = '" + User.userID + "' AND start BETWEEN CURRENT_DATE() AND DATE_ADD(CURRENT_DATE(), INTERVAL 1 MONTH) ORDER BY start desc");
                calendarDGV.Columns[calendarDGV.Columns.Count - 1].Visible = false;
                calendarDGV.Columns[calendarDGV.Columns.Count - 2].Visible = false;
            }
        }

        // UI BUTTONS
        private void customerBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            customer_form customer_form = new customer_form();
            customer_form.Show();
        }
        private void customerPic_Click(object sender, EventArgs e)
        {
            this.Hide();
            customer_form customer_form = new customer_form();
            customer_form.Show();
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            report_form report_form = new report_form();
            report_form.Show();
        }

        private void reportPic_Click(object sender, EventArgs e)
        {
            this.Hide();
            report_form report_form = new report_form();
            report_form.Show();
        }

        // FORM BUTTONS

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Appointment.AptType = aptTypeField.Text.ToString();
            Appointment.AptStartTime = dateTimePicker.Value.ToUniversalTime();
            Appointment.AptEndTime = endTimePicker.Value.ToUniversalTime();
            Appointment.getLastIndex();

            if (Appointment.OverlapCheck())
            {
                if (Appointment.EditingApt)
                {
                    Appointment.EditAppointment();
                }
                else
                {
                    Appointment.AddAppointment();
                }

                calendarDGV.DataSource = dbConnection.dgvHelper("SELECT customer.customerName AS Name, appointment.type, start, end, phone AS contact, customer.customerId, appointmentId FROM appointment JOIN customer ON appointment.customerId = customer.customerId JOIN address ON address.addressId = customer.addressId WHERE appointment.userId = '" + User.userID + "' ORDER BY start desc");
                DefaultInput();
                addNewBtn.Enabled = true;
            }
            else
            {
                MessageBox.Show("Cannot have overlapping appointments");
                saveBtn.Enabled = false;
            }

            
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DefaultInput();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Appointment.DeleteAppointment();
            calendarDGV.DataSource = dbConnection.dgvHelper("SELECT customer.customerName AS Name, appointment.type, start, end, phone AS contact, customer.customerId, appointmentId FROM appointment JOIN customer ON appointment.customerId = customer.customerId JOIN address ON address.addressId = customer.addressId WHERE appointment.userId = '" + User.userID + "' ORDER BY start desc");
            DefaultInput();
            dateComboBox.SelectedIndex = 0;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            nameBox.Enabled = false;
            saveBtn.Enabled = true;
            cancelBtn.Enabled = true;
            addNewBtn.Enabled = false;
            Appointment.EditingApt = true;
        }

        private void addNewBtn_Click(object sender, EventArgs e)
        {
            EnableForms();
            cancelBtn.Enabled = true;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            //dbConnection.dgvHelper
            calendarDGV.DataSource = Search.SearchAll("SELECT customer.customerName AS Name, appointment.type, start, end, phone AS contact, customer.customerId, appointmentId " +
                "FROM appointment " +
                "JOIN customer ON appointment.customerId = customer.customerId JOIN address ON address.addressId = customer.addressId " +
                "WHERE appointment.userId LIKE '%" + searchField.Text + "%' " +
                "OR customer.customerName LIKE '%" + searchField.Text + "%' " +
                "OR appointment.type LIKE '%" + searchField.Text + "%' OR phone LIKE '%" + searchField.Text + "%' ORDER BY start desc");
        }


        // VALIDATORS
        private bool allowSave()
        {
            return
                (!string.IsNullOrWhiteSpace(nameBox.Text)) && (!string.IsNullOrWhiteSpace(aptTypeField.Text) &&
                (endTimePicker.Value > dateTimePicker.Value));
        }

        private void nameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            saveBtn.Enabled = allowSave();

            try
            {
                Appointment.GetCustomerFromCombo(nameBox.Text);
            }
            catch
            {
                Customer.CustomerID = 0;
            }
        }

        private void aptTypeField_SelectedIndexChanged(object sender, EventArgs e)
        {
            saveBtn.Enabled = allowSave();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Appointment.AptStartTime = dateTimePicker.Value;
            saveBtn.Enabled = allowSave();

            if (!Appointment.BizHoursCheck())
            {
                saveBtn.Enabled = false;
                MessageBox.Show("Appointment is outside of business hours");
            }
        }

        private void endTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Appointment.AptStartTime = dateTimePicker.Value;
            saveBtn.Enabled = allowSave();

            if (endTimePicker.Value < dateTimePicker.Value)
            {
                MessageBox.Show("End time must be after start time");
            }

                if (!Appointment.BizHoursCheck())
            {
                saveBtn.Enabled = false;
                MessageBox.Show("Appointment is outside of business hours");
            }
        }


        // HELPERS
        public void clearFields()
        {
            nameBox.SelectedIndex = -1;
            aptTypeField.SelectedIndex = -1;
        }
        private void DefaultBtns()
        {
            editBtn.Enabled = false;
            deleteBtn.Enabled = false;
            cancelBtn.Enabled = false;
            saveBtn.Enabled = false;
        }

        private void DisableForm()
        {
            nameBox.Enabled = false;
            aptTypeField.Enabled = false;
            dateTimePicker.Enabled = false;
            endTimePicker.Enabled = false;
        }

        private void DefaultInput()
        {
            clearFields();
            DefaultBtns();
            DisableForm();

        }

        private void EnableForms()
        {
            nameBox.Enabled = true;
            aptTypeField.Enabled = true;
            dateTimePicker.Enabled = true;
            endTimePicker.Enabled = true;
        }

        
    }
}
