using SWEN;
using SWEN.Booking;
using SWEN_Assignment_3.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SWEN_Assignment_3.Booking
{
    public partial class CheckOut : Form
    {
       
        public CheckOut()
        {
            InitializeComponent();

        }

        private void recordReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new BookingMenu();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new CheckIn();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

       

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Update();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void CheckOut_Load(object sender, EventArgs e)
        {

           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label5.Visible == false)
            {
                label5.Visible = true;
                label6.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label7.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                label25.Visible = true;
                button5.Visible = true;
            }
            else
            {
                label5.Visible = false;
                label6.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label7.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                label25.Visible = false;
                button5.Visible = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button4.Visible = true;
            Book one = new Book();
            one = DBManager.getbookingByID(Convert.ToInt32(textBox1.Text));
            label13.Text = Convert.ToString(one.bookingid);
            label16.Text = one.check_in_date;
            label17.Text = one.check_out_date;
            label9.Text = Convert.ToString(one.no_of_rooms);
            int guestid = one.guestid;
            Guest two = new Guest();
            two = DBManager.getGuestByID(guestid);
            label19.Text = two.name;
            label24.Text = Convert.ToString(DBManager.gettotalroompricebyBID(Convert.ToInt32(textBox1.Text)));
            label23.Text = Convert.ToString((Convert.ToDouble(label24.Text) / 100) * 107);
        
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double alco = Convert.ToDouble(textBox3.Text) * Convert.ToDouble(textBox4.Text);
            double nonalco = Convert.ToDouble(textBox6.Text) * Convert.ToDouble(textBox7.Text);
            label25.Text = Convert.ToString(alco + nonalco);
            label21.Text = Convert.ToString(Convert.ToDouble(label25.Text) + Convert.ToDouble(label24.Text));
            label23.Text = Convert.ToString((Convert.ToDouble(label21.Text)/100)*107);
            label20.Visible = true;
            label21.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(DBManager.updatecheckout(Convert.ToInt32(label13.Text)))
            {
                MessageBox.Show("Check Out Successful!");
            }
            else
            {
                MessageBox.Show("Check Out Unsuccessful! Please try again!"); 
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new PrintInvoice();
            form.bookingID = Convert.ToInt32(label13.Text);
            form.noofalco = Convert.ToInt32(textBox3.Text);
            form.pricealco = Convert.ToDouble(textBox4.Text);
            form.noofnonalco = Convert.ToInt32(textBox6.Text);
            form.pricenonalco = Convert.ToDouble(textBox7.Text);
            if(label25.Text == "-")
            {}
            else
            {
                form.ttdrinks = Convert.ToDouble(label25.Text);
            }
            form.ttrooms = Convert.ToDouble(label24.Text);
            if (label21.Text == "-")
            { }
            else
            {
                form.ttprice = Convert.ToDouble(label21.Text); ;
            }
            form.ttpricegst = Convert.ToDouble(label23.Text);
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Home();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Delete();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

      
     
    }
}
