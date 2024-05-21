using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentSystem
{
    public partial class unitScreen : UserControl
    {
        public event EventHandler DashboardIconClicked;
        public unitScreen()
        {
            InitializeComponent();
            tableLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        private void addUnit_Click(object sender, EventArgs e)
        {
            addNewUnitForm form = new addNewUnitForm();
            form.Show();
        }
    }
}
