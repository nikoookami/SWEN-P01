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
            string guestID = "QW123";
            string name;
            string number;
            string email;
            string address;
            string postal;
            string country;
            string checkin;
            string checkout;
            string room;
            string adult;
            string children;
            name = textBox1.Text;
            number = textBox10.Text;
            email = textBox9.Text;
            address = textBox8.Text;
            postal = textBox7.Text;
            country=textBox6.Text;
            checkin = dateTimePicker1.Text;
            checkout = dateTimePicker2.Text;
             room = comboBox1.Text;
             adult = comboBox3.Text;
             children = comboBox4.Text;

             booking p = new booking(name, number, email, address, postal, country, adult, children, checkin, checkout, room, guestID);
            DataBase.Insertbookinfo(p);
        }
    }
}
