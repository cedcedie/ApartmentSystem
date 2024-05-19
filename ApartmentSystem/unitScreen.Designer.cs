namespace ApartmentSystem
{
    partial class unitScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.occupiedLabelNum = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.vacantLabelNum = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.addUnit = new System.Windows.Forms.Button();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.occupiedLabelNum);
            this.panel7.Location = new System.Drawing.Point(247, 44);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(180, 93);
            this.panel7.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "OCCUPIED";
            // 
            // occupiedLabelNum
            // 
            this.occupiedLabelNum.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occupiedLabelNum.Location = new System.Drawing.Point(114, 37);
            this.occupiedLabelNum.Name = "occupiedLabelNum";
            this.occupiedLabelNum.Size = new System.Drawing.Size(66, 46);
            this.occupiedLabelNum.TabIndex = 1;
            this.occupiedLabelNum.Text = "0";
            this.occupiedLabelNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.vacantLabelNum);
            this.panel3.Location = new System.Drawing.Point(27, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 93);
            this.panel3.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "VACANT\r\n";
            // 
            // vacantLabelNum
            // 
            this.vacantLabelNum.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vacantLabelNum.Location = new System.Drawing.Point(114, 37);
            this.vacantLabelNum.Name = "vacantLabelNum";
            this.vacantLabelNum.Size = new System.Drawing.Size(66, 46);
            this.vacantLabelNum.TabIndex = 1;
            this.vacantLabelNum.Text = "0";
            this.vacantLabelNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(27, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 256);
            this.panel1.TabIndex = 57;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.SaddleBrown;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(760, 148);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(104, 25);
            this.comboBox1.TabIndex = 56;
            this.comboBox1.Text = "ALL UNIT";
            // 
            // addUnit
            // 
            this.addUnit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.addUnit.FlatAppearance.BorderSize = 0;
            this.addUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUnit.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUnit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addUnit.Location = new System.Drawing.Point(760, 97);
            this.addUnit.Name = "addUnit";
            this.addUnit.Size = new System.Drawing.Size(104, 28);
            this.addUnit.TabIndex = 55;
            this.addUnit.Text = "ADD NEW UNIT";
            this.addUnit.UseVisualStyleBackColor = false;
            // 
            // unitScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.addUnit);
            this.Name = "unitScreen";
            this.Size = new System.Drawing.Size(890, 480);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label occupiedLabelNum;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label vacantLabelNum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button addUnit;
    }
}
