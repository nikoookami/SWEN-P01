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
             checkin=label2.Text;
             checkout = label4.Text;
             room = label8.Text;
             adult = label11.Text;
             children = label10.Text;
             
           booking p=new booking(checkin, checkout, room, adult, children);
            DataBase.Insertbookinfo(p);
        }
    }
}
