namespace ApartmentSystem
{
    partial class clerkDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clerkDashboard));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.settingsIcon = new System.Windows.Forms.Button();
            this.paymentIcon = new System.Windows.Forms.Button();
            this.TenantIcon = new System.Windows.Forms.Button();
            this.unitsIcon = new System.Windows.Forms.Button();
            this.dashboardIcon = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.clerkDashboardScreen1 = new ApartmentSystem.clerkDashboardScreen();
            this.clerkPaymentScreen1 = new ApartmentSystem.clerkPaymentScreen();
            this.clerkUnitScreen1 = new ApartmentSystem.clerkUnitScreen();
            this.clerkTenantScreen1 = new ApartmentSystem.clerkTenantScreen();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.SaddleBrown;
            this.sidePanel.Location = new System.Drawing.Point(0, 34);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(12, 60);
            this.sidePanel.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(363, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "ARENIA\'S APARTMENT SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1080, 80);
            this.panel5.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(162, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(890, 480);
            this.panel3.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Bisque;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.sidePanel);
            this.panel2.Controls.Add(this.settingsIcon);
            this.panel2.Controls.Add(this.paymentIcon);
            this.panel2.Controls.Add(this.TenantIcon);
            this.panel2.Controls.Add(this.unitsIcon);
            this.panel2.Controls.Add(this.dashboardIcon);
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 500);
            this.panel2.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(162, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(890, 480);
            this.panel4.TabIndex = 27;
            // 
            // settingsIcon
            // 
            this.settingsIcon.FlatAppearance.BorderSize = 0;
            this.settingsIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsIcon.Image = ((System.Drawing.Image)(resources.GetObject("settingsIcon.Image")));
            this.settingsIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsIcon.Location = new System.Drawing.Point(12, 354);
            this.settingsIcon.Name = "settingsIcon";
            this.settingsIcon.Size = new System.Drawing.Size(158, 60);
            this.settingsIcon.TabIndex = 12;
            this.settingsIcon.Text = "Settings";
            this.settingsIcon.UseVisualStyleBackColor = true;
            // 
            // paymentIcon
            // 
            this.paymentIcon.FlatAppearance.BorderSize = 0;
            this.paymentIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paymentIcon.Image = ((System.Drawing.Image)(resources.GetObject("paymentIcon.Image")));
            this.paymentIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.paymentIcon.Location = new System.Drawing.Point(12, 274);
            this.paymentIcon.Name = "paymentIcon";
            this.paymentIcon.Size = new System.Drawing.Size(158, 60);
            this.paymentIcon.TabIndex = 12;
            this.paymentIcon.Text = "Payment";
            this.paymentIcon.UseVisualStyleBackColor = true;
            this.paymentIcon.Click += new System.EventHandler(this.paymentIcon_Click_1);
            // 
            // TenantIcon
            // 
            this.TenantIcon.FlatAppearance.BorderSize = 0;
            this.TenantIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TenantIcon.Image = ((System.Drawing.Image)(resources.GetObject("TenantIcon.Image")));
            this.TenantIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TenantIcon.Location = new System.Drawing.Point(12, 194);
            this.TenantIcon.Name = "TenantIcon";
            this.TenantIcon.Size = new System.Drawing.Size(158, 60);
            this.TenantIcon.TabIndex = 12;
            this.TenantIcon.Text = "Tenant";
            this.TenantIcon.UseVisualStyleBackColor = true;
            this.TenantIcon.Click += new System.EventHandler(this.TenantIcon_Click_1);
            // 
            // unitsIcon
            // 
            this.unitsIcon.FlatAppearance.BorderSize = 0;
            this.unitsIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unitsIcon.Image = ((System.Drawing.Image)(resources.GetObject("unitsIcon.Image")));
            this.unitsIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.unitsIcon.Location = new System.Drawing.Point(12, 114);
            this.unitsIcon.Name = "unitsIcon";
            this.unitsIcon.Size = new System.Drawing.Size(158, 60);
            this.unitsIcon.TabIndex = 12;
            this.unitsIcon.Text = "Units";
            this.unitsIcon.UseVisualStyleBackColor = true;
            this.unitsIcon.Click += new System.EventHandler(this.unitsIcon_Click_1);
            // 
            // dashboardIcon
            // 
            this.dashboardIcon.FlatAppearance.BorderSize = 0;
            this.dashboardIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardIcon.Image = ((System.Drawing.Image)(resources.GetObject("dashboardIcon.Image")));
            this.dashboardIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardIcon.Location = new System.Drawing.Point(12, 34);
            this.dashboardIcon.Name = "dashboardIcon";
            this.dashboardIcon.Size = new System.Drawing.Size(158, 60);
            this.dashboardIcon.TabIndex = 12;
            this.dashboardIcon.Text = "Dashboard";
            this.dashboardIcon.UseVisualStyleBackColor = true;
            this.dashboardIcon.Click += new System.EventHandler(this.dashboardIcon_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Location = new System.Drawing.Point(-1, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 19;
            // 
            // pictureBox16
            // 
            this.pictureBox16.Location = new System.Drawing.Point(-418, 260);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(200, 80);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox16.TabIndex = 18;
            this.pictureBox16.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.clerkDashboardScreen1);
            this.panel6.Controls.Add(this.clerkPaymentScreen1);
            this.panel6.Controls.Add(this.clerkUnitScreen1);
            this.panel6.Controls.Add(this.clerkTenantScreen1);
            this.panel6.Location = new System.Drawing.Point(172, 80);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(890, 480);
            this.panel6.TabIndex = 22;
            // 
            // clerkDashboardScreen1
            // 
            this.clerkDashboardScreen1.Location = new System.Drawing.Point(0, 0);
            this.clerkDashboardScreen1.Name = "clerkDashboardScreen1";
            this.clerkDashboardScreen1.Size = new System.Drawing.Size(890, 480);
            this.clerkDashboardScreen1.TabIndex = 4;
            // 
            // clerkPaymentScreen1
            // 
            this.clerkPaymentScreen1.Location = new System.Drawing.Point(-3, 0);
            this.clerkPaymentScreen1.Name = "clerkPaymentScreen1";
            this.clerkPaymentScreen1.Size = new System.Drawing.Size(890, 480);
            this.clerkPaymentScreen1.TabIndex = 2;
            // 
            // clerkUnitScreen1
            // 
            this.clerkUnitScreen1.Location = new System.Drawing.Point(0, 0);
            this.clerkUnitScreen1.Name = "clerkUnitScreen1";
            this.clerkUnitScreen1.Size = new System.Drawing.Size(890, 480);
            this.clerkUnitScreen1.TabIndex = 1;
            // 
            // clerkTenantScreen1
            // 
            this.clerkTenantScreen1.Location = new System.Drawing.Point(0, 0);
            this.clerkTenantScreen1.Name = "clerkTenantScreen1";
            this.clerkTenantScreen1.Size = new System.Drawing.Size(890, 480);
            this.clerkTenantScreen1.TabIndex = 0;
            // 
            // clerkDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 561);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "clerkDashboard";
            this.Text = "clerkDashboard";
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button settingsIcon;
        private System.Windows.Forms.Button paymentIcon;
        private System.Windows.Forms.Button TenantIcon;
        private System.Windows.Forms.Button unitsIcon;
        private System.Windows.Forms.Button dashboardIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private clerkDashboardScreen clerkDashboardScreen1;
        private clerkPaymentScreen clerkPaymentScreen1;
        private clerkUnitScreen clerkUnitScreen1;
        private clerkTenantScreen clerkTenantScreen1;
    }
}