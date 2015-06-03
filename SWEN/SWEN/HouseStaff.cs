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
    public partial class HouseStaff : Form
    {
        public HouseStaff()
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

        private void buttonAddStaff_Click(object sender, EventArgs e)
        {
            //this.Hide();
            var form = new AddStaff();
            //form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //this.Hide();
            var form = new UpdateStaff();
            //form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
