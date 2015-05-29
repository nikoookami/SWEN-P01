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

namespace Login
{
    public partial class AddStaff : Form
    {

        public static string connectionString = "Server=SIRIUS;Database=swen;User ID=bspiSCM;password=Nikoookami02";
        public static SqlConnection cnn = new SqlConnection(connectionString);

        public AddStaff()
        {
            InitializeComponent();
        }

        private void AddStaff_Load(object sender, EventArgs e)
        {

        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {

            // Get data from fields
            string username= textBoxUserName.Text;
            string password= textBoxPassword.Text;
            string staffName = textBoxStaffName.Text;
            DateTime dob = dateTimePickerDoB.Value;
            string address = textBoxPostalCode.Text;
            string postalCode = textBoxPostalCode.Text;
            string phoneNum = textBoxPhone.Text;
            string bankAcc = textBoxBankAcc.Text;
            string staffLvl = comboBoxStaffLevel.Text;
            string dutyType = comboBoxDutyType.Text;
            try
            {
                cnn.Open();

                //bool success = doSomeWork(username, password, staffName, dob, address, postalCode,phoneNum, bankAcc, staffLvl, dutyType);

                cnn.Close();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private bool doSomeWork(string username, string password, string staffName, DateTime dob, string address, string postalCode, string phoneNum, string bankAcc, string staffLvl, string dutyType)
        {
            string cmdString = "INSERT INTO Staff (staffUsername,staffPassword,staffName,staffBirthDate," +
                "staffAddress,staffPostalCode,staffPhoneNo,staffBankAccNo,dutyId)" +
            " VALUES (@valSatffUsername, @valStaffPassword,@valStaffName,@valStaffBirthDate,@valStaffAddress,@valStaffPostalCode,@valStaffPhoneNo," +
            "@valStaffBankAccNo,@valDutyId)";

            bool successOrNot = false;
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = cnn;
                comm.CommandText = cmdString;
                comm.Parameters.AddWithValue("@valSatffUsername", username);
                comm.Parameters.AddWithValue("@valStaffPassword", password);
                comm.Parameters.AddWithValue("@valStaffName", staffName);
                comm.Parameters.AddWithValue("@valStaffBirthDate", dob);
                comm.Parameters.AddWithValue("@valStaffAddress", address);
                comm.Parameters.AddWithValue("@valStaffPostalCode", postalCode);
                comm.Parameters.AddWithValue("@valStaffPhoneNo", phoneNum);
                comm.Parameters.AddWithValue("@valStaffBankAccNo", bankAcc);
                comm.Parameters.AddWithValue("@valDutyId", dutyType);

                comm.ExecuteNonQuery();
                // Check Success
                successOrNot = true;
            }
            return true;
        }
    }
}
