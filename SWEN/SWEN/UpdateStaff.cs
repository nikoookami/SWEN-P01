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
    public partial class UpdateStaff : Form
    {
        public UpdateStaff()
        {
            InitializeComponent();
        }

        private void UpdateStaff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'delonixRegiaDataSet.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.delonixRegiaDataSet.Staff);
            //MessageBox.Show(comboBoxSelectStaffID.SelectedValue.ToString());

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnn = new SqlConnection("Server=SIRIUS;Database=DelonixRegia;User ID=bspiSCM;password=Nikoookami02");
                SqlCommand updateCommand = new SqlCommand("UPDATE Staff SET " +
    "name= @name, dob= @dob, bankno = @bankno, address = @address,telno= @telno, username=@username WHERE staffid= @staffid");
                cnn.Open();
                updateCommand.Connection = cnn;
                updateCommand.Parameters.AddWithValue("@name", textBoxStaffName.Text);
                updateCommand.Parameters.AddWithValue("@dob", dateTimePickerDoB.Value);
                updateCommand.Parameters.AddWithValue("@bankno", textBoxBankAcc.Text);
                updateCommand.Parameters.AddWithValue("@address", textBoxAddress.Text);
                updateCommand.Parameters.AddWithValue("@telno", textBoxTelno.Text);
                updateCommand.Parameters.AddWithValue("@username", textBoxUsername.Text);
                updateCommand.Parameters.AddWithValue("@staffid", comboBoxSelectStaffID.SelectedValue.ToString());

                updateCommand.ExecuteNonQuery();
                cnn.Close();
                // Check Success
                //successOrNot = true;
                MessageBox.Show("Done!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error!" + Environment.NewLine + e.ToString());
            }
        }

        private void comboBoxSelectStaffID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Server=SIRIUS;Database=DelonixRegia;User ID=bspiSCM;password=Nikoookami02");
            SqlCommand selectCommand = new SqlCommand("SELECT * FROM Staff WHERE staffid='" + comboBoxSelectStaffID.SelectedValue + "'", cnn);
            SqlDataAdapter ada = new SqlDataAdapter(selectCommand);
            DataTable dt = new DataTable();
            ada.Fill(dt);

            DataRow dr = dt.Rows[0];
            textBoxStaffName.Text = dr["name"].ToString();
            dateTimePickerDoB.Value = DateTime.Parse(dr["dob"].ToString());
            textBoxBankAcc.Text = dr["bankno"].ToString();
            textBoxAddress.Text = dr["address"].ToString();
            textBoxTelno.Text = dr["telno"].ToString();
            textBoxUsername.Text = dr["username"].ToString();
        }
    }
}
