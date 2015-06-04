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
    public partial class CancelShift : Form
    {
        static SqlConnection cnn = new SqlConnection("Server=SIRIUS;Database=DelonixRegia;User ID=bspiSCM;password=Nikoookami02");

        public CancelShift()
        {
            InitializeComponent();
        }

        private void ConfirmCancel_Click(object sender, EventArgs e)
        {
            if (comboBoxSelectShiftID.SelectedItem == null)
            {
                MessageBox.Show("Please select an item");
            }
            else
            {
                SqlCommand deleteCommand = new SqlCommand("DELETE FROM Housekeeping WHERE housekeepingid='" + comboBoxSelectShiftID.SelectedItem + "'", cnn);
                cnn.Open();
                deleteCommand.Connection = cnn;

                deleteCommand.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Done!");

            }
        }

        private void CancelShift_Load(object sender, EventArgs e)
        {
            SqlCommand selectCommand = new SqlCommand("SELECT * FROM Housekeeping", cnn);
            SqlDataAdapter ada = new SqlDataAdapter(selectCommand);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
               comboBoxSelectShiftID.Items.Add(row["housekeepingid"].ToString());
            }

        }
    }
}
