﻿using System;
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
    public partial class paymentScreen : UserControl
    {
        public event EventHandler DashboardIconClicked;
        public paymentScreen()
        {
            InitializeComponent();
        }

        private void addUnit_Click(object sender, EventArgs e)
        {
            paymentForm addUser = new paymentForm();
            addUser.Show();
      
        }
    }
}