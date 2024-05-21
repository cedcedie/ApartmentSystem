namespace ApartmentSystem
{
    partial class admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.settingsIcon = new System.Windows.Forms.Button();
            this.paymentIcon = new System.Windows.Forms.Button();
            this.TenantIcon = new System.Windows.Forms.Button();
            this.unitsIcon = new System.Windows.Forms.Button();
            this.dashboardIcon = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.userSettingScreen1 = new ApartmentSystem.userSettingScreen();
            this.paymentScreen1 = new ApartmentSystem.paymentScreen();
            this.unitScreen1 = new ApartmentSystem.unitScreen();
            this.tenantsScreen1 = new ApartmentSystem.tenantsScreen();
            this.dashboardScreen1 = new ApartmentSystem.dashboardScreen();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Location = new System.Drawing.Point(-1, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Bisque;
            this.panel2.Controls.Add(this.sidePanel);
            this.panel2.Controls.Add(this.settingsIcon);
            this.panel2.Controls.Add(this.paymentIcon);
            this.panel2.Controls.Add(this.TenantIcon);
            this.panel2.Controls.Add(this.unitsIcon);
            this.panel2.Controls.Add(this.dashboardIcon);
            this.panel2.Location = new System.Drawing.Point(0, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 500);
            this.panel2.TabIndex = 13;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.SaddleBrown;
            this.sidePanel.Location = new System.Drawing.Point(0, 34);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(12, 60);
            this.sidePanel.TabIndex = 14;
            // 
            // settingsIcon
            // 
            this.settingsIcon.FlatAppearance.BorderSize = 0;
            this.settingsIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsIcon.Font = new System.Drawing.Font("Poppins SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsIcon.Image = ((System.Drawing.Image)(resources.GetObject("settingsIcon.Image")));
            this.settingsIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsIcon.Location = new System.Drawing.Point(12, 294);
            this.settingsIcon.Name = "settingsIcon";
            this.settingsIcon.Size = new System.Drawing.Size(158, 60);
            this.settingsIcon.TabIndex = 12;
            this.settingsIcon.Text = "Settings";
            this.settingsIcon.UseVisualStyleBackColor = true;
            this.settingsIcon.Click += new System.EventHandler(this.settingsIcon_Click);
            // 
            // paymentIcon
            // 
            this.paymentIcon.FlatAppearance.BorderSize = 0;
            this.paymentIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paymentIcon.Font = new System.Drawing.Font("Poppins SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentIcon.Image = ((System.Drawing.Image)(resources.GetObject("paymentIcon.Image")));
            this.paymentIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.paymentIcon.Location = new System.Drawing.Point(12, 229);
            this.paymentIcon.Name = "paymentIcon";
            this.paymentIcon.Size = new System.Drawing.Size(158, 60);
            this.paymentIcon.TabIndex = 12;
            this.paymentIcon.Text = "Payment";
            this.paymentIcon.UseVisualStyleBackColor = true;
            this.paymentIcon.Click += new System.EventHandler(this.paymentIcon_Click);
            // 
            // TenantIcon
            // 
            this.TenantIcon.FlatAppearance.BorderSize = 0;
            this.TenantIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TenantIcon.Font = new System.Drawing.Font("Poppins SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenantIcon.Image = ((System.Drawing.Image)(resources.GetObject("TenantIcon.Image")));
            this.TenantIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TenantIcon.Location = new System.Drawing.Point(12, 164);
            this.TenantIcon.Name = "TenantIcon";
            this.TenantIcon.Size = new System.Drawing.Size(158, 60);
            this.TenantIcon.TabIndex = 12;
            this.TenantIcon.Text = "Tenant";
            this.TenantIcon.UseVisualStyleBackColor = true;
            this.TenantIcon.Click += new System.EventHandler(this.TenantIcon_Click);
            // 
            // unitsIcon
            // 
            this.unitsIcon.FlatAppearance.BorderSize = 0;
            this.unitsIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unitsIcon.Font = new System.Drawing.Font("Poppins SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitsIcon.Image = ((System.Drawing.Image)(resources.GetObject("unitsIcon.Image")));
            this.unitsIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.unitsIcon.Location = new System.Drawing.Point(12, 99);
            this.unitsIcon.Name = "unitsIcon";
            this.unitsIcon.Size = new System.Drawing.Size(158, 60);
            this.unitsIcon.TabIndex = 12;
            this.unitsIcon.Text = "Units";
            this.unitsIcon.UseVisualStyleBackColor = true;
            this.unitsIcon.Click += new System.EventHandler(this.unitsIcon_Click);
            // 
            // dashboardIcon
            // 
            this.dashboardIcon.FlatAppearance.BorderSize = 0;
            this.dashboardIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardIcon.Font = new System.Drawing.Font("Poppins SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(40)))), ((int)(((byte)(17)))));
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(0, -1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1080, 80);
            this.panel5.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(356, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "ARSENIA\'S APARTMENT SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.userSettingScreen1);
            this.panel3.Controls.Add(this.paymentScreen1);
            this.panel3.Controls.Add(this.unitScreen1);
            this.panel3.Controls.Add(this.tenantsScreen1);
            this.panel3.Controls.Add(this.dashboardScreen1);
            this.panel3.Location = new System.Drawing.Point(171, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(893, 481);
            this.panel3.TabIndex = 16;
            // 
            // userSettingScreen1
            // 
            this.userSettingScreen1.Location = new System.Drawing.Point(0, 0);
            this.userSettingScreen1.Name = "userSettingScreen1";
            this.userSettingScreen1.Size = new System.Drawing.Size(890, 480);
            this.userSettingScreen1.TabIndex = 6;
            // 
            // paymentScreen1
            // 
            this.paymentScreen1.Location = new System.Drawing.Point(0, 1);
            this.paymentScreen1.Name = "paymentScreen1";
            this.paymentScreen1.Size = new System.Drawing.Size(890, 480);
            this.paymentScreen1.TabIndex = 4;
            // 
            // unitScreen1
            // 
            this.unitScreen1.BackColor = System.Drawing.Color.White;
            this.unitScreen1.Location = new System.Drawing.Point(0, 1);
            this.unitScreen1.Name = "unitScreen1";
            this.unitScreen1.Size = new System.Drawing.Size(890, 480);
            this.unitScreen1.TabIndex = 2;
            // 
            // tenantsScreen1
            // 
            this.tenantsScreen1.Location = new System.Drawing.Point(0, 1);
            this.tenantsScreen1.Name = "tenantsScreen1";
            this.tenantsScreen1.Size = new System.Drawing.Size(890, 480);
            this.tenantsScreen1.TabIndex = 1;
            // 
            // dashboardScreen1
            // 
            this.dashboardScreen1.Location = new System.Drawing.Point(0, 1);
            this.dashboardScreen1.Name = "dashboardScreen1";
            this.dashboardScreen1.Size = new System.Drawing.Size(890, 480);
            this.dashboardScreen1.TabIndex = 0;
            // 
            // pictureBox16
            // 
            this.pictureBox16.Image = global::ApartmentSystem.Properties.Resources.brown1;
            this.pictureBox16.Location = new System.Drawing.Point(-418, 259);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(200, 80);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox16.TabIndex = 5;
            this.pictureBox16.TabStop = false;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 561);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "label";
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button settingsIcon;
        private System.Windows.Forms.Button paymentIcon;
        private System.Windows.Forms.Button TenantIcon;
        private System.Windows.Forms.Button unitsIcon;
        private System.Windows.Forms.Button dashboardIcon;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.Panel panel3;
        private unitScreen unitScreen1;
        private tenantsScreen tenantsScreen1;
        private dashboardScreen dashboardScreen1;
        private paymentScreen paymentScreen1;
        private userSettingScreen userSettingScreen1;
    }
}