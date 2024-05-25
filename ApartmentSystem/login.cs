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
using System.Xml.Linq;

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
            SqlConnection conn = new SqlConnection(Connection.conn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT username, password FROM Admin", conn);
            SqlDataReader read = cmd.ExecuteReader();
            bool isLogin = false;
            while (read.Read())
            {
                if (userInput.Text == read.GetValue(0).ToString() && passwordInput.Text == read.GetValue(1).ToString())
                {
                    isLogin = true;
                    break;
                }
                else
                {
                    isLogin = false;
                }
            }
            if (isLogin)
            {
                admin dashboard = new admin();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password. \n Please try again.", "ALERT", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clerkDashboard dashboard = new clerkDashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
