using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string checkin;
            string checkout;
            string room;
            string adult;
            string children;
            checkin = dateTimePicker1.Text;
            checkout = dateTimePicker2.Text;
             room = comboBox1.Text;
             adult = comboBox3.Text;
             children = comboBox4.Text;
             
           booking p=new booking(checkin, checkout, room, adult, children);
            DataBase.Insertbookinfo(p);
        }
    }
}
