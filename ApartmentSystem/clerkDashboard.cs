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
    public partial class clerkDashboard : Form
    {
        public clerkDashboard()
        {
            InitializeComponent();
            sidePanel.Height = dashboardIcon.Height;
            clerkDashboardScreen1 = new clerkDashboardScreen();
            clerkDashboardScreen1.Dock = DockStyle.Fill;
            clerkDashboardScreen1.ViewDetailsTenantsClicked += DashboardScreen1_ViewDetailsclerkTenantsClicked;
            clerkDashboardScreen1.ViewDetailsUnitsClicked += DashboardScreen1_ViewDetailsUnitsClicked;
            clerkDashboardScreen1.ViewDetailsPaymentsClicked += DashboardScreen1_ViewDetailsPaymentsClicked;

            clerkPaymentScreen1 = new clerkPaymentScreen();
            clerkPaymentScreen1.Dock = DockStyle.Fill;
            clerkPaymentScreen1.DashboardIconClicked += PaymentScreen1_DashboardIconClicked;

            clerkUnitScreen1 = new clerkUnitScreen();
            clerkUnitScreen1.Dock = DockStyle.Fill;
            clerkUnitScreen1.DashboardIconClicked += UnitScreen_DashboardIconClicked;

            clerkTenantScreen1 = new clerkTenantScreen();
            clerkTenantScreen1.Dock = DockStyle.Fill;
            clerkTenantScreen1.DashboardIconClicked += clerkTenantScreen_DashboardIconClicked;


            ShowDashboardScreen();
        }

        // Event handlers for dashboard icon clicked events
        private void PaymentScreen1_DashboardIconClicked(object sender, EventArgs e)
        {
            ShowDashboardScreen();
        }


        private void InvoiceScreen1_DashboardIconClicked(object sender, EventArgs e)
        {
            ShowDashboardScreen();
        }

        private void DashboardScreen1_ViewDetailsPaymentsClicked(object sender, EventArgs e)
        {
            ShowPaymentScreen();
        }

        private void ShowPaymentScreen()
        {
            panel4.Controls.Clear();
            panel4.Controls.Add(clerkPaymentScreen1);
            clerkDashboardScreen1.Visible = false;
            clerkTenantScreen1.Visible = false;
            clerkUnitScreen1.Visible = false;
            clerkPaymentScreen1.Visible = true;
            sidePanel.Height = paymentIcon.Height;
            sidePanel.Top = paymentIcon.Top;
        }

        private void DashboardScreen1_ViewDetailsUnitsClicked(object sender, EventArgs e)
        {
            ShowUnitScreen();
        }

        private void ShowDashboardScreen()
        {
            panel4.Controls.Clear();
            panel4.Controls.Add(clerkDashboardScreen1);
            clerkDashboardScreen1.Visible = true;
            clerkTenantScreen1.Visible = false;
            clerkUnitScreen1.Visible = false;
            clerkPaymentScreen1.Visible = false;
            sidePanel.Height = dashboardIcon.Height;
            sidePanel.Top = dashboardIcon.Top;
        }

        private void DashboardScreen1_ViewDetailsclerkTenantsClicked(object sender, EventArgs e)
        {
            ShowTenantScreen();
        }

        private void ShowTenantScreen()
        {
            panel4.Controls.Clear();
            panel4.Controls.Add(clerkTenantScreen1);
            clerkDashboardScreen1.Visible = false;
            clerkTenantScreen1.Visible = true;
            clerkUnitScreen1.Visible = false;
            clerkPaymentScreen1.Visible = false;
            sidePanel.Height = TenantIcon.Height;
            sidePanel.Top = TenantIcon.Top;
        }
        private void clerkTenantScreen_DashboardIconClicked(object sender, EventArgs e)
        {
            ShowDashboardScreen();
        }

        private void ShowUnitScreen()
        {
            panel4.Controls.Clear();
            panel4.Controls.Add(clerkUnitScreen1);
            sidePanel.Height = unitsIcon.Height;
            sidePanel.Top = unitsIcon.Top;
        }
        private void UnitScreen_DashboardIconClicked(object sender, EventArgs e)
        {
            ShowDashboardScreen();
        }

        private void dashboardIcon_Click(object sender, EventArgs e)
        {
            ShowDashboardScreen();
        }

        private void unitsIcon_Click_1(object sender, EventArgs e)
        {
            ShowUnitScreen();
        }

        private void TenantIcon_Click_1(object sender, EventArgs e)
        {
            ShowTenantScreen();
        }
        private void paymentIcon_Click_1(object sender, EventArgs e)
        {
            ShowPaymentScreen();
        }

        private void ViewDetailsUnitsClicked_Handler(object sender, EventArgs e)
        {
            ShowUnitScreen();
        }
        private void ViewDetailsTenantsClicked_Handler(object sender, EventArgs e)
        {
            ShowTenantScreen();
        }

        private void ViewDetailsPaymentsClicked_Handler(object sender, EventArgs e)
        {
            ShowPaymentScreen();
        }
    }
}
