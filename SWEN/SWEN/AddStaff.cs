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
        //EDIT TO TRY MERGE!
        public static string connectionString = "Server=SIRIUS;Database=DelonixRegia;User ID=bspiSCM;password=Nikoookami02";
        public static SqlConnection cnn = new SqlConnection(connectionString);

        public AddStaff()
        {
            InitializeComponent();
        }

        private void AddStaff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'delonixRegiaDataSet.Housekeeping' table. You can move, or remove it, as needed.
            SqlCommand selectCommand = new SqlCommand("SELECT * FROM Housekeeping", cnn);
            SqlDataAdapter ada = new SqlDataAdapter(selectCommand);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {

                comboBoxDutyID.Items.Add(row["housekeepingid"].ToString());
            }
            comboBoxDutyID.SelectedItem = null;
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
                string dutyID;

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

                                        // Check DUTYTYPE
                                        if (comboBoxDutyID.SelectedItem != null)
                                        {
                                            countCheck++;
                                            dutyID = comboBoxDutyID.Text;

                                            // If all correct update Database                    
                                            if (countCheck == 4)
                                            {
                                                cnn.Open();

                                                bool success = doSomeWork(username, staffName, dob, address, phoneNum, bankAcc, dutyID);

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
                                        else
                                        {                
                                            if (countCheck == 3)
                                            {
                                                cnn.Open();

                                                bool success = doSomeWork(username, staffName, dob, address, phoneNum, bankAcc, null);

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
        private bool doSomeWork(string username, string staffName, DateTime dob, string address, string phoneNum, string bankAcc, string dutyID)
        {
            bool successOrNot = false;
            try
            {
                if (dutyID != null)
                {
                    string cmdString = "INSERT INTO Staff (name,dob,bankno,address," +
                        "telno,housekeepingid,username)" +
                        " VALUES (@name, @dob,@bankno,@address," +
                        "@telno,@housekeepingid,@username)";
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = cnn;
                        comm.CommandText = cmdString;
                        comm.Parameters.AddWithValue("@name", staffName);
                        comm.Parameters.AddWithValue("@dob", dob);
                        comm.Parameters.AddWithValue("@bankno", bankAcc);
                        comm.Parameters.AddWithValue("@address", address);
                        comm.Parameters.AddWithValue("@telno", phoneNum);
                        comm.Parameters.AddWithValue("@housekeepingid", dutyID);
                        comm.Parameters.AddWithValue("@username", username);

                        comm.ExecuteNonQuery();
                        // Check Success
                        successOrNot = true;

                    }
                }
                else
                {
                    string cmdString = "INSERT INTO Staff (name,dob,bankno,address," +
                        "telno,username)" +
                        " VALUES (@name, @dob,@bankno,@address," +
                        "@telno,@username)";
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = cnn;
                        comm.CommandText = cmdString;
                        comm.Parameters.AddWithValue("@name", staffName);
                        comm.Parameters.AddWithValue("@dob", dob);
                        comm.Parameters.AddWithValue("@bankno", bankAcc);
                        comm.Parameters.AddWithValue("@address", address);
                        comm.Parameters.AddWithValue("@telno", phoneNum);
                        comm.Parameters.AddWithValue("@username", username);

                        comm.ExecuteNonQuery();
                        // Check Success
                        successOrNot = true;

                    }
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
