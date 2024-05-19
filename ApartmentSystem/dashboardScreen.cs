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
    public partial class dashboardScreen : UserControl
    {
        public event EventHandler ViewDetailsUnitsClicked;
        public event EventHandler ViewDetailsTenantsClicked;
        public event EventHandler ViewDetailsInvoiceClicked;
        public event EventHandler ViewDetailsPaymentsClicked;

        public dashboardScreen()
        {
            InitializeComponent();
        }

        private void viewDetailsUnits_Click(object sender, EventArgs e)
        {
            ViewDetailsUnitsClicked?.Invoke(this, EventArgs.Empty);
        }

        private void viewDetailsTenants_Click(object sender, EventArgs e)
        {
            ViewDetailsTenantsClicked?.Invoke(this, EventArgs.Empty);
        }

        private void viewDetailsInvoice_Click(object sender, EventArgs e)
        {
            ViewDetailsInvoiceClicked?.Invoke(this, EventArgs.Empty);
        }

        private void viewDetailsPayments_Click(object sender, EventArgs e)
        {
            ViewDetailsPaymentsClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
