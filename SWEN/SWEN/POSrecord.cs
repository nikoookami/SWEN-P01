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
    public partial class POSrecord : Form
    {
        public POSrecord()
        {
            InitializeComponent();
            //textBox3.Text = "a";  
        }

        private void POSrecord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'delonixRegiaDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.delonixRegiaDataSet.Product);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // textBox3.Text = "a";  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string guestid= textBox1.Text;
            dataGridView1.DataSource = DataBase.GetSalesInfo(guestid);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string guestid = textBox1.Text;
            string productname = comboBox1.Text;
            string quantity = textBox3.Text;
            string dis = textBox2.Text;
            double total;
            string productID = DataBase.Getproductid(productname);
                string price = DataBase.Getproductprice(productname);
                total = Convert.ToDouble(price) * Convert.ToDouble(quantity) * ((100-Convert.ToDouble(dis)) / 100);
                    DataBase.Insertsalesinfo(guestid, productname, productID, price, quantity,total.ToString());
            dataGridView1.DataSource = DataBase.GetSalesInfo(guestid);
        }

       

      
    }
}
