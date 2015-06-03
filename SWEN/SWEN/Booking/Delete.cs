using SWEN_Assignment_3.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Booking
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(DBManager.deleteBooking(Convert.ToInt32(textBox1.Text))==true)
            {
                MessageBox.Show("Booking Successfully Deleted!");
            }
            else
            {
                MessageBox.Show("Booking Was Not Deleted! Please Try Again!");
            }

        }
    }
}
