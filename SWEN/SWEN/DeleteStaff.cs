using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWEN
{
    public partial class DeleteStaff: Form
    {
        int selectedID;
        public DeleteStaff()
        {
            InitializeComponent();
        }

        private void DeleteStaff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'delonixRegiaDataSet.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.delonixRegiaDataSet.Staff);

        }

        private void buttonConfirmDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog =
            MessageBox.Show("Delete Staff", "Are you sure?", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                SqlConnection cnn = new SqlConnection("Server=SIRIUS;Database=DelonixRegia;User ID=bspiSCM;password=Nikoookami02");
                SqlCommand deleteCommand = new SqlCommand("DELETE FROM Staff WHERE staffid='" + comboBoxSelectStaffID.SelectedValue + "'", cnn);
                cnn.Open();
                deleteCommand.Connection = cnn;

                deleteCommand.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Done!");
            }
            else if (dialog == DialogResult.No)
            {
                this.Close();
            }
        }
    }
}
