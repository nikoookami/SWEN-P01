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
        }

        private void POSrecord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'delonixRegiaDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.delonixRegiaDataSet.Product);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
              
        }
    }
}
