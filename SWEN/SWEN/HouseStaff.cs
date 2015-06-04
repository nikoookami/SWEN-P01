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
    public partial class HouseStaff : Form
    {
        public HouseStaff()
        {
            InitializeComponent();
        }

        private void HouseStaff_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            SqlConnection cnn = new SqlConnection("Server=SIRIUS;Database=DelonixRegia;User ID=bspiSCM;password=Nikoookami02");
            SqlDataAdapter ada = new SqlDataAdapter("SELECT * FROM Staff", cnn);
            DataTable dt = new DataTable();
            ada.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["staffid"].ToString());
                listitem.SubItems.Add(dr["name"].ToString());
                listitem.SubItems.Add(dr["dob"].ToString());
                listitem.SubItems.Add(dr["bankno"].ToString());
                listitem.SubItems.Add(dr["address"].ToString());
                listitem.SubItems.Add(dr["telno"].ToString());
                listitem.SubItems.Add(dr["housekeepingid"].ToString());
                listitem.SubItems.Add(dr["username"].ToString());
                listView1.Items.Add(listitem);

            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            SqlDataAdapter adaRoom = new SqlDataAdapter("SELECT * FROM Housekeeping", cnn);
            DataTable dtRoom = new DataTable();
            adaRoom.Fill(dtRoom);

            for (int i = 0; i < dtRoom.Rows.Count; i++)
            {
                DataRow dr = dtRoom.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["housekeepingid"].ToString());
                listitem.SubItems.Add(dr["housekeepingtype"].ToString());
                listitem.SubItems.Add(dr["housekeepingdate"].ToString());
                listitem.SubItems.Add(dr["housekeepingtime"].ToString());
                listitem.SubItems.Add(dr["staffid"].ToString());
                listitem.SubItems.Add(dr["roomid"].ToString());
                listView2.Items.Add(listitem);

            }
        }
        private void buttonBackToHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Home();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void buttonAddStaff_Click(object sender, EventArgs e)
        {
            //this.Hide();
            var form = new AddStaff();
            //form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void buttonUpdateStaff_Click(object sender, EventArgs e)
        {
            //this.Hide();
            var form = new UpdateStaff();
            //form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void buttonCancelShift_Click(object sender, EventArgs e)
        {
            //this.Hide();
            var form = new CancelShift();
            //form.Closed += (s, args) => this.Close();
            form.Show();

        }

        private void buttonUpdateShift_Click(object sender, EventArgs e)
        {
            //this.Hide();
            var form = new UpdateShift();
            //form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void buttonDeleteStaff_Click(object sender, EventArgs e)
        {
            //this.Hide();
            var form = new DeleteStaff();
            //form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void buttonCreateShift_Click(object sender, EventArgs e)
        {
            //this.Hide();
            var form = new CreateShift();
            //form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
