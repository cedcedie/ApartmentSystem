using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ApartmentSystem
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            admin dashboard = new admin();
            dashboard.Show();
            this.Hide();

            SqlConnection conn = new SqlConnection(Connection.conn);
            //SqlAdapter
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clerkDashboard dashboard = new clerkDashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
