using Login;
using Login.Booking;
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
            BOOK one = new BOOK();
            one = DBManager.getbookingByID(Convert.ToInt32(textBox1.Text));
            label2.Text = Convert.ToString(one.BookingID);
            textBox2.Text = one.Check_In_Date;
            textBox3.Text = one.Check_Out_Date;
            textBox4.Text = Convert.ToString(one.No_Of_Adults);
            textBox5.Text = Convert.ToString(one.No_Of_Children);
            int guestid = one.GuestID;
            Guest two = new Guest();
            two = DBManager.getGuestByID(guestid);
            textBox6.Text = two.Name;
            textBox7.Text = Convert.ToString(two.Phone);
            textBox8.Text = two.Email;
            textBox9.Text = two.Address;
            textBox10.Text = Convert.ToString(two.PostalCode);
            textBox11.Text = two.Country;


            

   }

        private void Update_Load(object sender, EventArgs e)
        {
            textBox2.Text ="00/00/0000";
             textBox3.Text ="00/00/0000";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            BOOK updatedbook = new BOOK();
           //updatedbook.BookingID = Convert.ToInt32(textBox1.Text);
           int bkid = Convert.ToInt32(textBox1.Text);
            BOOK oldbook = DBManager.getbookingByID(bkid);

            updatedbook.BookingID = bkid;
            updatedbook.Check_In_Date = textBox2.Text;
            updatedbook.Check_Out_Date = textBox3.Text;
            updatedbook.No_Of_Rooms = oldbook.No_Of_Rooms;
            updatedbook.No_Of_Adults = Convert.ToInt32(textBox4.Text);
            updatedbook.No_Of_Children = Convert.ToInt32(textBox5.Text);
            updatedbook.GuestID = oldbook.GuestID;
            updatedbook.StaffID = oldbook.StaffID;
            DBManager.updateBooking(updatedbook);
            Guest oldguest = DBManager.getGuestByID(updatedbook.GuestID);
            Guest updatedguest = new Guest();
           // updatedguest.GuestID = oldbook.GuestID;

            updatedguest.GuestID = updatedbook.GuestID;
            updatedguest.Name = textBox6.Text;
            updatedguest.Phone = Convert.ToInt32(textBox7.Text);
            updatedguest.Email = textBox8.Text;
            updatedguest.Address = textBox9.Text;
            updatedguest.PostalCode = Convert.ToInt32(textBox10.Text);
            updatedguest.Country = textBox11.Text;
            updatedguest.PaymentType = oldguest.PaymentType;
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
        

      
    

