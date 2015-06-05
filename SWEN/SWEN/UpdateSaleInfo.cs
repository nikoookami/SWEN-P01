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
    public partial class UpdateSaleInfo : Form
    {
        public UpdateSaleInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string guestid = textBox1.Text;
            dataGridView1.DataSource = DataBase.GetSalesInfo(guestid);
        }

        private void UpdateSaleInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'delonixRegiaDataSet2.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.delonixRegiaDataSet2.Product);
            // TODO: This line of code loads data into the 'delonixRegiaDataSet1.Sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.delonixRegiaDataSet1.Sales);

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

        private void button4_Click(object sender, EventArgs e)
        {
            string id=textBox4.Text;
            string q = DataBase.Getproductqant(id);
            string p = DataBase.Getproductpricesales(id);
            textBox5.Text = q;
            textBox6.Text = p;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string guestid = textBox1.Text;
            string id = textBox4.Text;
            string qan = textBox5.Text;
            string price = textBox6.Text;
            double total = Convert.ToDouble(qan) * Convert.ToDouble(price);
            DataBase.UpdateSalesinfo(qan,price,id,total.ToString());
            dataGridView1.DataSource = DataBase.GetSalesInfo(guestid);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string guestid = textBox1.Text;
            string name=comboBox2.Text;
            DataBase.deletebyname(name);
                  dataGridView1.DataSource = DataBase.GetSalesInfo(guestid);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string guestid = textBox1.Text;

            DataBase.deletebyid(guestid);
            dataGridView1.DataSource = DataBase.GetSalesInfo(guestid);
        }

       

      
    }
}
