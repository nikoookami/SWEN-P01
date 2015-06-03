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
    public partial class CreateShift : Form
    {
        public static string connectionString = "Server=SIRIUS;Database=DelonixRegia;User ID=bspiSCM;password=Nikoookami02";
        public static SqlConnection cnn = new SqlConnection(connectionString);

        public CreateShift()
        {
            InitializeComponent();
        }

        private void buttonCreateShift_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();

                string dutyType = comboBoxDutyType.SelectedItem.ToString();
                string date = dateTimePickerDate.Value.ToString("dd-MM-yyyy");
                string startTime = dateTimePickerStartTime.Value.ToString("hh:mm tt");
                if (comboBoxStaffID.SelectedItem != null)
                {
                    string staffID = comboBoxStaffID.SelectedValue.ToString();
                    if (comboBoxRoomID.SelectedItem != null)//Got both staffID and roomID
                    {
                        string roomID = comboBoxRoomID.SelectedValue.ToString();

                        string cmdString = "INSERT INTO Housekeeping (housekeepingtype,housekeepingdate,housekeepingtime," +
                            "staffid,roomid)" +
                            " VALUES (@housekeepingtype, @housekeepingdate,@housekeepingtime," +
                            "@staffid,@roomid)";
                        using (SqlCommand comm = new SqlCommand())
                        {
                            comm.Connection = cnn;
                            comm.CommandText = cmdString;
                            comm.Parameters.AddWithValue("@housekeepingtype", dutyType);
                            comm.Parameters.AddWithValue("@housekeepingdate", date);
                            comm.Parameters.AddWithValue("@housekeepingtime", startTime);
                            comm.Parameters.AddWithValue("@staffid", staffID);
                            comm.Parameters.AddWithValue("@roomid", roomID);
                            comm.ExecuteNonQuery();
                        }
                    }
                    else//Got staffID, no roomID
                    {
                        string cmdString = "INSERT INTO Housekeeping (housekeepingtype,housekeepingdate,housekeepingtime," +
                            "staffid)" +
                            " VALUES (@housekeepingtype, @housekeepingdate,@housekeepingtime," +
                            "@staffid)";
                        using (SqlCommand comm = new SqlCommand())
                        {
                            comm.Connection = cnn;
                            comm.CommandText = cmdString;
                            comm.Parameters.AddWithValue("@housekeepingtype", dutyType);
                            comm.Parameters.AddWithValue("@housekeepingdate", date);
                            comm.Parameters.AddWithValue("@housekeepingtime", startTime);
                            comm.Parameters.AddWithValue("@staffid", staffID);
                            comm.ExecuteNonQuery();
                        }
                    }
                }
                else
                {
                    if (comboBoxRoomID.SelectedItem != null)//No staffID, got room ID
                    {
                        string roomID = comboBoxRoomID.SelectedItem.ToString();

                        string cmdString = "INSERT INTO Housekeeping (housekeepingtype,housekeepingdate,housekeepingtime," +
                            "roomid)" +
                            " VALUES (@housekeepingtype, @housekeepingdate,@housekeepingtime," +
                            "@roomid)";
                        using (SqlCommand comm = new SqlCommand())
                        {
                            comm.Connection = cnn;
                            comm.CommandText = cmdString;
                            comm.Parameters.AddWithValue("@housekeepingtype", dutyType);
                            comm.Parameters.AddWithValue("@housekeepingdate", date);
                            comm.Parameters.AddWithValue("@housekeepingtime", startTime);
                            comm.Parameters.AddWithValue("@roomid", roomID);
                            comm.ExecuteNonQuery();
                        }
                    }
                    else//No both
                    {
                        string cmdString = "INSERT INTO Housekeeping (housekeepingtype,housekeepingdate,housekeepingtime" +
                            ")" +
                            " VALUES (@housekeepingtype, @housekeepingdate,@housekeepingtime" +
                            ")";
                        using (SqlCommand comm = new SqlCommand())
                        {
                            comm.Connection = cnn;
                            comm.CommandText = cmdString;
                            comm.Parameters.AddWithValue("@housekeepingtype", dutyType);
                            comm.Parameters.AddWithValue("@housekeepingdate", date);
                            comm.Parameters.AddWithValue("@housekeepingtime", startTime);
                            comm.ExecuteNonQuery();
                        }
                    }
                }
                cnn.Close();
                MessageBox.Show("Done!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void CreateShift_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'delonixRegiaDataSet.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.delonixRegiaDataSet.Room);
            // TODO: This line of code loads data into the 'delonixRegiaDataSet.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.delonixRegiaDataSet.Staff);

            comboBoxRoomID.SelectedItem = null;
            comboBoxStaffID.SelectedItem = null;
        }
    }
}
