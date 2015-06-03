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
    public partial class AddStaff : Form
    {

        public static string connectionString = "Server=SIRIUS;Database=DelonixRegia;User ID=bspiSCM;password=Nikoookami02";
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
            try
            {
                string username;
                string password;
                string staffName;
                DateTime dob;
                string address;
                string postalCode;
                string phoneNum;
                string bankAcc;
                string staffLvl;
                string dutyType;

                int countCheck = 0;

                if (countCheck == 0)
                {

                    staffName = textBoxStaffName.Text;  // FULLNAME
                    dob = dateTimePickerDoB.Value;      // DOB
                    address = textBoxAddress.Text;      //ADDRESS

                    // Check USERNAME
                    if (!textBoxUserName.Text.Contains(" "))
                    {
                        countCheck++;
                        username = textBoxUserName.Text;

                        // Check PASSWORD
                        if (!textBoxPassword.Text.Contains(" "))
                        {
                            countCheck++;
                            password = textBoxPassword.Text;

                            // Check if POSTALCODE
                            if (textBoxPostalCode.Text.Length == 6)
                            {
                                int intPostalCode;
                                bool isNumeric = int.TryParse(textBoxPostalCode.Text, out intPostalCode);
                                if (isNumeric)
                                {
                                    countCheck++;
                                    postalCode = textBoxPostalCode.Text;

                                    // Check if PHONENUM
                                    if (textBoxPhone.Text.Length == 8)
                                    {
                                        int intPhoneNum;
                                        bool isNumeric2 = int.TryParse(textBoxPhone.Text, out intPhoneNum);
                                        if (isNumeric2)
                                        {
                                            countCheck++;
                                            phoneNum = textBoxPhone.Text;

                                            // Check BANKACC
                                            if (textBoxBankAcc.Text.Length == 9 || textBoxBankAcc.Text.Length == 10)
                                            {
                                                int intBankAcc;
                                                bool isNumeric3 = int.TryParse(textBoxBankAcc.Text, out intBankAcc);
                                                if (isNumeric3)
                                                {
                                                    countCheck++;
                                                    bankAcc = textBoxBankAcc.Text;

                                                    // Check STAFFLVL
                                                    if (comboBoxStaffLevel.SelectedItem != null)
                                                    {
                                                        countCheck++;
                                                        staffLvl = comboBoxStaffLevel.Text;

                                                        // Check DUTYTYPE
                                                        if (comboBoxDutyType.SelectedItem != null)
                                                        {
                                                            countCheck++;
                                                            dutyType = comboBoxDutyType.Text;

                                                            // If all correct update Database                    
                                                            if (countCheck == 7)
                                                            {
                                                                cnn.Open();

                                                                bool success = doSomeWork(username, password, staffName, dob, address, postalCode, phoneNum, bankAcc, staffLvl, dutyType);

                                                                cnn.Close();

                                                                this.Close();
                                                                goto done;
                                                            }
                                                            else
                                                            {
                                                                redo();
                                                                goto done;
                                                            }
                                                        }
                                                        redo();
                                                        goto done;
                                                    }
                                                    redo();
                                                    goto done;
                                                }
                                                redo();
                                                goto done;
                                            }
                                            redo();
                                            goto done;
                                        }
                                        redo();
                                        goto done;
                                    }
                                    redo();
                                    goto done;
                                }
                                redo();
                                goto done;
                            }
                            redo();
                            goto done;
                        }
                        redo();
                        goto done;
                    }
                    redo();
                    goto done;
                }
            done: ;
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void redo()
        {
            MessageBox.Show("Please Enter Value In Correct Format");

            FormClosed += (o, a) => new AddStaff().ShowDialog();

            Hide();
            Close();
        }
        private bool doSomeWork(string username, string password, string staffName, DateTime dob, string address, string postalCode, string phoneNum, string bankAcc, string staffLvl, string dutyType)
        {
            bool successOrNot = false;
            try
            {
                string cmdString = "INSERT INTO Staff (staffUsername,staffPassword,staffName,staffBirthDate," +
                    "staffAddress,staffPostalCode,staffPhoneNo,staffBankAccNo,dutyId)" +
                " VALUES (@valSatffUsername, @valStaffPassword,@valStaffName,@valStaffBirthDate,@valStaffAddress,@valStaffPostalCode,@valStaffPhoneNo," +
                "@valStaffBankAccNo,@valDutyId)";
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
            }
            catch (Exception e)
            {
                successOrNot = false;
                MessageBox.Show(e.ToString() + Environment.NewLine + "Please try again!");
            }
            return successOrNot;
        }
    }
}
