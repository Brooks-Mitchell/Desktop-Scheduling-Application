using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace C969
{
    public partial class report_form : Form
    {
        public report_form()
        {
            InitializeComponent();

            numberTypeDGV.DataSource = dbConnection.dgvHelper("SELECT type AS Type, COUNT(appointmentId) as Count FROM appointment GROUP BY type");

            allScheduleDGV.DataSource = dbConnection.dgvHelper("select user.userName, title, description, contact, type, start, end " +
                "from appointment JOIN user ON appointment.userId = user.userId order by user.userId; ");

            workLoadDGV.DataSource = dbConnection.dgvHelper("SELECT userName AS User, COUNT(appointment.appointmentId) AS 'Scheduled Appointments' FROM user JOIN appointment ON user.userId = appointment.userId GROUP BY userName ORDER BY 'Scheduled Appointments' desc; ");

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
    }
}
