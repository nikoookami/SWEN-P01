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
            SqlCommand selectCommandStaff = new SqlCommand("SELECT * FROM Staff", cnn);
            SqlDataAdapter adaStaff = new SqlDataAdapter(selectCommandStaff);
            DataTable dtStaff = new DataTable();
            adaStaff.Fill(dtStaff);
            foreach (DataRow row in dtStaff.Rows)
            {
                if (!comboBoxStaffID.Items.Contains(row["staffid"].ToString()))
                {
                    comboBoxStaffID.Items.Add(row["staffid"].ToString());
                }
            }
            SqlCommand selectCommandRoom = new SqlCommand("SELECT * FROM Room", cnn);
            SqlDataAdapter adaRoom = new SqlDataAdapter(selectCommandRoom);
            DataTable dtRoom = new DataTable();
            adaRoom.Fill(dtRoom);
            foreach (DataRow row in dtRoom.Rows)
            {
                if (!comboBoxRoomID.Items.Contains(row["roomid"].ToString()))
                {
                    comboBoxRoomID.Items.Add(row["roomid"].ToString());
                }
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
            if (dr["staffid"].ToString().Length < 1)
            {
                comboBoxStaffID.SelectedItem = null;
            }
            else
            {
                comboBoxStaffID.SelectedItem = dr["staffid"].ToString();
            }
            if (dr["roomid"].ToString().Length < 1)
            {
                comboBoxRoomID.SelectedItem = null;
            }else
            {
                comboBoxRoomID.SelectedItem = dr["roomid"].ToString();
            }

        }

        private void buttonUpdateShift_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand updateCommand = new SqlCommand("UPDATE Housekeeping SET " +
    "housekeepingtype= @housekeepingtype, housekeepingdate= @housekeepingdate, " +
    "housekeepingtime = @housekeepingtime, staffid = @staffid,roomid= @roomid WHERE housekeepingid= @housekeepingid");
                cnn.Open();
                updateCommand.Connection = cnn;
                updateCommand.Parameters.AddWithValue("@housekeepingtype", comboBoxDutyType.SelectedItem);
                updateCommand.Parameters.AddWithValue("@housekeepingdate", dateTimePickerDate.Value);
                updateCommand.Parameters.AddWithValue("@housekeepingtime", dateTimePickerStartTime.Value.TimeOfDay);
                updateCommand.Parameters.AddWithValue("@staffid", comboBoxStaffID.SelectedItem);
                updateCommand.Parameters.AddWithValue("@roomid", comboBoxRoomID.SelectedItem);
                updateCommand.Parameters.AddWithValue("@housekeepingid", comboBoxSelectDutyID.SelectedItem);

                updateCommand.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Done!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error!" + Environment.NewLine + e.ToString());
            }
        }
    }
}
