using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWEN
{
    public partial class UpdateShift : Form
    {
        static SqlConnection cnn = new SqlConnection("Server=SIRIUS;Database=DelonixRegia;User ID=bspiSCM;password=Nikoookami02");

        public UpdateShift()
        {
            InitializeComponent();
        }

        private void UpdateShift_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'delonixRegiaDataSet.Housekeeping' table. You can move, or remove it, as needed.
            //this.housekeepingTableAdapter.Fill(this.delonixRegiaDataSet.Housekeeping);
            SqlCommand selectCommand = new SqlCommand("SELECT * FROM Housekeeping", cnn);
            SqlDataAdapter ada = new SqlDataAdapter(selectCommand);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                comboBoxSelectDutyID.Items.Add(row["housekeepingid"].ToString());
            }
        }

        private void comboBoxSelectDutyID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            SqlCommand selectCommand = new SqlCommand("SELECT * FROM Housekeeping WHERE housekeepingid='" + comboBoxSelectDutyID.SelectedItem + "'", cnn);
            SqlDataAdapter ada = new SqlDataAdapter(selectCommand);
            DataTable dt = new DataTable();
            ada.Fill(dt);

            DataRow dr = dt.Rows[0];
            comboBoxDutyType.SelectedItem = dr["housekeepingtype"].ToString();
            dateTimePickerDate.Value = DateTime.Parse(dr["housekeepingdate"].ToString());
            dateTimePickerStartTime.Value = DateTime.Parse(dr["housekeepingtime"].ToString());
            comboBoxStaffID.SelectedItem = dr["staffid"].ToString();
            comboBoxRoomID.SelectedItem= dr["roomid"].ToString();

        }

        private void buttonCreateShift_Click(object sender, EventArgs e)
        {

        }
    }
}
