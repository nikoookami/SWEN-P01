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
    public partial class CheckIn : Form
    {
        public CheckIn()
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


        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new CheckOut();
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

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DBManager.ViewBookingByBID(Convert.ToInt32(textBox1.Text));
           //label3.Text = Convert.ToString(DBManager.RetrieveBookingByID(Convert.ToInt32(textBox1.Text)));
        }

        private void CheckIn_Load(object sender, EventArgs e)
        {


            
           dataGridView1.DataSource = DBManager.RetrieveAllBooking();
            //label3.Text = Convert.ToString(DBManager.RetrieveAllBooking());
           //label3.Text = Convert.ToString(DBManager.GetTotalCount());
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            if (DBManager.updatecheckin(Convert.ToInt32(textBox2.Text)))
            {
                MessageBox.Show("Check In Successful!");
            }
            else
            {
                MessageBox.Show("Check In Unsuccessful! Please try again!");
            } 

                
            }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Delete();
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
        }
    }

