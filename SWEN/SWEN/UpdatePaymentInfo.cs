using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWEN
{
    public partial class UpdatePaymentInfo : Form
    {
        public UpdatePaymentInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string id= textBox1.Text;
           payment u = DataBase.Getpaymentinfo(id);
           textBox2.Text = u.Ownerid.ToString();
           textBox3.Text = u.Cardholdername;
           textBox4.Text = u.Expirydate;
           textBox5.Text = u.CreaditNO;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            payment u=new payment();
            u.Ownerid=Convert.ToInt32(textBox2.Text);
            u.Cardholdername=textBox3.Text;
            u.Expirydate=textBox4.Text;
            u.CreaditNO=textBox5.Text;
            DataBase.Updatepaymentinfo(u,id);
            //Updatepaymentinfo
        }

       

       
    }
}
