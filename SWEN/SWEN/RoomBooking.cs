﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class RoomBooking : Form
    {
        public RoomBooking()
        {
            InitializeComponent();
        }

        private void buttonBackToHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Home();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            var form = new Checkin();
            //form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.Hide();
            var form = new Checkout();
            //form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
