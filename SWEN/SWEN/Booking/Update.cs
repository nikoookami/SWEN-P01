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
    public partial class Update : Form
    {
        public Update()
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

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new CheckOut();
            form.Closed += (s, args) => this.Close();                                                                                                    
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book one = new Book();
            one = DBManager.getbookingByID(Convert.ToInt32(textBox1.Text));
            label2.Text = Convert.ToString(one.bookingid);
            textBox2.Text = one.check_in_date;
            textBox3.Text = one.check_out_date;
            textBox4.Text = Convert.ToString(one.no_of_adults);
            textBox5.Text = Convert.ToString(one.no_of_children);
            int guestid = one.guestid;
            Guest two = new Guest();
            two = DBManager.getGuestByID(guestid);
            textBox6.Text = two.name;
            textBox7.Text = Convert.ToString(two.phone);
            textBox8.Text = two.email;
            textBox9.Text = two.address;
            textBox10.Text = Convert.ToString(two.postalcode);
            textBox11.Text = two.country;


            

   }

        private void Update_Load(object sender, EventArgs e)
        {
            textBox2.Text ="00/00/0000";
             textBox3.Text ="00/00/0000";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Book updatedbook = new Book();
           //updatedbook.BookingID = Convert.ToInt32(textBox1.Text);
           int bkid = Convert.ToInt32(textBox1.Text);
            Book oldbook = DBManager.getbookingByID(bkid);

            updatedbook.bookingid = bkid;
            updatedbook.check_in_date = textBox2.Text;
            updatedbook.check_out_date = textBox3.Text;
            updatedbook.no_of_rooms = oldbook.no_of_rooms;
            updatedbook.no_of_adults = Convert.ToInt32(textBox4.Text);
            updatedbook.no_of_children = Convert.ToInt32(textBox5.Text);
            updatedbook.guestid = oldbook.guestid;
            updatedbook.staffid = oldbook.staffid;
            DBManager.updateBooking(updatedbook);
            Guest oldguest = DBManager.getGuestByID(updatedbook.guestid);
            Guest updatedguest = new Guest();
           // updatedguest.GuestID = oldbook.GuestID;

            updatedguest.guestid = updatedbook.guestid;
            updatedguest.name = textBox6.Text;
            updatedguest.phone = Convert.ToInt32(textBox7.Text);
            updatedguest.email = textBox8.Text;
            updatedguest.address = textBox9.Text;
            updatedguest.postalcode = Convert.ToInt32(textBox10.Text);
            updatedguest.country = textBox11.Text;
            updatedguest.paymenttype = oldguest.paymenttype;
            DBManager.updateGuest(updatedguest);
            if(DBManager.updateBooking(updatedbook)==true&&DBManager.updateGuest(updatedguest)==true)
            {
                MessageBox.Show("Update Successful!");
            }
            else
            {
                MessageBox.Show("Update UnSuccessful! Please try again");
            }
               
          

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
        

      
    

