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
    public partial class checkbill : Form
    {
        public checkbill()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id=textBox1.Text;
            dataGridView1.DataSource = DataBase.GetAllBillInfo(id);
        }
    }
}
