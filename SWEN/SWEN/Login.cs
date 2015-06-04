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
    public partial class Login : Form
    {
        static SqlConnection cnn = new SqlConnection("Server=SIRIUS;Database=DelonixRegia;User ID=bspiSCM;password=Nikoookami02");

        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            bool correctUsername = false;
            SqlCommand selectCommand = new SqlCommand("SELECT * FROM Staff", cnn);
            SqlDataAdapter ada = new SqlDataAdapter(selectCommand);
            DataTable dt = new DataTable();
            ada.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                if(username == row["username"].ToString())
                {
                    correctUsername = true;
                    break;
                }
            }
            if (correctUsername)
            {
                this.Hide();
                var form = new Home(username);
                form.Closed += (s, args) => this.Close();
                form.Show();
            }
            else
            {
                MessageBox.Show("Wrong username!");
            }
        }
    }
}
