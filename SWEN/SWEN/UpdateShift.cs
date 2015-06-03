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
        public UpdateShift()
        {
            InitializeComponent();
        }

        private void UpdateShift_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'delonixRegiaDataSet.Housekeeping' table. You can move, or remove it, as needed.
            this.housekeepingTableAdapter.Fill(this.delonixRegiaDataSet.Housekeeping);

        }

        private void comboBoxSelectDutyID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            SqlConnection cnn = new SqlConnection("Server=SIRIUS;Database=DelonixRegia;User ID=bspiSCM;password=Nikoookami02");
            SqlCommand selectCommand = new SqlCommand("SELECT * FROM Housekeeping WHERE housekeepingid='" + comboBoxSelectDutyID.SelectedValue + "'", cnn);
            SqlDataAdapter ada = new SqlDataAdapter(selectCommand);
            DataTable dt = new DataTable();
            ada.Fill(dt);

            DataRow dr = dt.Rows[0];
            comboBoxDutyType.SelectedValue = dr["housekeepingtype"].ToString();
            dateTimePickerDate.Value = DateTime.Parse(dr["housekeepingdate"].ToString());
            dateTimePickerStartTime.Value = DateTime.Parse(dr["housekeepingtime"].ToString());
            comboBoxStaffID.SelectedValue = dr["staffid"].ToString();
            comboBoxRoomID.SelectedValue = dr["roomid"].ToString();

        }
    }
}
