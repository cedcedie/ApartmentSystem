using System;
using System.Windows.Forms;

namespace ApartmentSystem
{
    public partial class admin : Form
    {
    

        public admin()
        {
            InitializeComponent();
        
            sidePanel.Height = dashboardIcon.Height;
            dashboardScreen1.ViewDetailsUnitsClicked += ViewDetailsUnitsClicked_Handler;
            dashboardScreen1.ViewDetailsTenantsClicked += ViewDetailsTenantsClicked_Handler;
            dashboardScreen1.ViewDetailsInvoiceClicked += ViewDetailsInvoiceClicked_Handler;
            dashboardScreen1.ViewDetailsPaymentsClicked += ViewDetailsPaymentsClicked_Handler;

            dashboardScreen1 = new dashboardScreen();
            dashboardScreen1.Dock = DockStyle.Fill;
            dashboardScreen1.ViewDetailsTenantsClicked += DashboardScreen1_ViewDetailsTenantsClicked;
            dashboardScreen1.ViewDetailsUnitsClicked += DashboardScreen1_ViewDetailsUnitsClicked;
            dashboardScreen1.ViewDetailsInvoiceClicked += DashboardScreen1_ViewDetailsInvoiceClicked;
            dashboardScreen1.ViewDetailsPaymentsClicked += DashboardScreen1_ViewDetailsPaymentsClicked;

            tenantsScreen1 = new tenantsScreen();
            tenantsScreen1.Dock = DockStyle.Fill;
            tenantsScreen1.DashboardIconClicked += TenantScreen_DashboardIconClicked;

            unitScreen1 = new unitScreen();
            unitScreen1.Dock = DockStyle.Fill;
            unitScreen1.DashboardIconClicked += UnitScreen_DashboardIconClicked;

            invoiceScreen1 = new invoiceScreen();
            invoiceScreen1.Dock = DockStyle.Fill;
            invoiceScreen1.DashboardIconClicked += InvoiceScreen1_DashboardIconClicked;

            paymentScreen1 = new paymentScreen();
            paymentScreen1.Dock = DockStyle.Fill;
            paymentScreen1.DashboardIconClicked += PaymentScreen1_DashboardIconClicked;

            ShowDashboardScreen();
        }

        private void PaymentScreen1_DashboardIconClicked(object sender, EventArgs e)
        {
            ShowDashboardScreen();
        }

        private void ShowInvoiceScreen()
        {
            panel3.Controls.Clear();
            panel3.Controls.Add(invoiceScreen1);
            dashboardScreen1.Visible = false;
            tenantsScreen1.Visible = false;
            unitScreen1.Visible = false;
            invoiceScreen1.Visible = true;
            paymentScreen1.Visible = false;
            sidePanel.Height = invoiceIcon.Height;
            sidePanel.Top = invoiceIcon.Top;
        }
        private void DashboardScreen1_ViewDetailsInvoiceClicked(object sender, EventArgs e)
        {
            ShowInvoiceScreen();
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
            panel3.Controls.Clear();
            panel3.Controls.Add(paymentScreen1);
            dashboardScreen1.Visible = false;
            tenantsScreen1.Visible = false;
            unitScreen1.Visible = false;
            invoiceScreen1.Visible = false;
            paymentScreen1.Visible = true;
            sidePanel.Height = paymentIcon.Height;
            sidePanel.Top = paymentIcon.Top;
        }

        private void DashboardScreen1_ViewDetailsUnitsClicked(object sender, EventArgs e)
        {
          ShowUnitScreen();
        }

        private void dashboardIcon_Click(object sender, EventArgs e)
        {
            ShowDashboardScreen();
        }

        private void ShowDashboardScreen()
        {
            panel3.Controls.Clear();
            panel3.Controls.Add(dashboardScreen1);
            dashboardScreen1.Visible = true;
            tenantsScreen1.Visible = false;
            unitScreen1.Visible = false;
            invoiceScreen1.Visible = false;
            paymentScreen1.Visible = false;
            sidePanel.Height = dashboardIcon.Height;
            sidePanel.Top = dashboardIcon.Top;
        }

        private void DashboardScreen1_ViewDetailsTenantsClicked(object sender, EventArgs e)
        {
            ShowTenantScreen();
        }
        private void ShowTenantScreen()
        {
            panel3.Controls.Clear();
            panel3.Controls.Add(tenantsScreen1);
            dashboardScreen1.Visible = false;
            tenantsScreen1.Visible = true;
            unitScreen1.Visible = false;
            invoiceScreen1.Visible = false;
            paymentScreen1.Visible = false;
            sidePanel.Height = TenantIcon.Height;
            sidePanel.Top = TenantIcon.Top;
        }

        private void TenantIcon_Click(object sender, EventArgs e)
        {
            ShowTenantScreen();
        }

        private void TenantScreen_DashboardIconClicked(object sender, EventArgs e)
        {
            ShowDashboardScreen();
        }
        private void ShowUnitScreen()
        {
            panel3.Controls.Clear();
            panel3.Controls.Add(unitScreen1);
            dashboardScreen1.Visible = false;
            tenantsScreen1.Visible = false;
            unitScreen1.Visible = true;
            invoiceScreen1.Visible = false;
            paymentScreen1.Visible = false;
            sidePanel.Height = unitsIcon.Height;
            sidePanel.Top = unitsIcon.Top;
        }
        private void unitsIcon_Click(object sender, EventArgs e)
        {
            ShowUnitScreen();
        }
        private void ViewDetailsUnitsClicked_Handler(object sender, EventArgs e)
        {
            ShowUnitScreen();
        }
        private void UnitScreen_DashboardIconClicked(object sender, EventArgs e)
        {
            ShowDashboardScreen();
        }

        private void invoiceIcon_Click(object sender, EventArgs e)
        {
           ShowInvoiceScreen();
        }

        private void paymentIcon_Click(object sender, EventArgs e)
        {
            ShowPaymentScreen();
        }

        private void settingsIcon_Click(object sender, EventArgs e)
        {
            sidePanel.Height = settingsIcon.Height;
            sidePanel.Top = settingsIcon.Top;
        }

        private void ViewDetailsTenantsClicked_Handler(object sender, EventArgs e)
        {
            sidePanel.Height = TenantIcon.Height;
            sidePanel.Top = TenantIcon.Top;
        }

        private void ViewDetailsInvoiceClicked_Handler(object sender, EventArgs e)
        {
            sidePanel.Height = invoiceIcon.Height;
            sidePanel.Top = invoiceIcon.Top;
        }

        private void ViewDetailsPaymentsClicked_Handler(object sender, EventArgs e)
        {
            sidePanel.Height = paymentIcon.Height;
            sidePanel.Top = paymentIcon.Top;
        }

       
    }
}
