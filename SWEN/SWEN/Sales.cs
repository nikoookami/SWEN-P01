using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWEN
{
    public partial class Sales : Form
    {
        public Sales()
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
            var form = new checkbill();
            //form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.Hide();
            var form = new UpdateSaleInfo();
            //form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            var form = new POSrecord();
            //form.Closed += (s, args) => this.Close();
            form.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //this.Hide();
            var form = new UpdatePaymentInfo();
            //form.Closed += (s, args) => this.Close();
            form.Show();

        }

        private void RoomBooking_Load(object sender, EventArgs e)
        {
           // dataGridView1.DataSource = DataBase.GetAllInfo();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;
            //Call ShowDialog
            if (printDlg.ShowDialog() == DialogResult.OK)
                printDoc.Print();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            string id =textBox1.Text;
            sales m = DataBase.Getsalesinfo(id);
            billing n = DataBase.Getallbillinfobyid(id);
            double total=0;
            string H = "<html><h2 align='center'>Invoice Information</h2><body>"
                +"<div>CusotmerID:"+id+"</div>";
           
                H += "<div>productID: " + m.Productid + "</div>"
                  + "<div>product Name: " + m.Productname + "</div>"
                  + "<div>prices: " + m.Price + "</div>"
                  + "<div>quantity: " + m.Quan + "</div>"
                  + "<div>total: " + m.Total + "</div>";
                H += "<br>";
                H += "<div>bill ID: " + n.Extrabillid + "</div>"
                  + "<div>description: " + n.Desc + "</div>"
                  + "<div>fees: " + n.Fees + "</div>"
                  + "<div>quantity: " + n.Qan + "</div>"
                  + "<div>total: " + n.Total + "</div>";
               H += "<br>";
               total = Convert.ToDouble(m.Total) + Convert.ToDouble(n.Total);
               H += "<div>Overall Total: " + total.ToString() + "</div>";
              H += "</body></html>";

            webBrowser1.DocumentText=H;
        }

       
    }
}
