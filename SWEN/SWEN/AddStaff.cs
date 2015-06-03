using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWEN
{
    public partial class AddStaff : Form
    {
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
            string staffName = textBoxStaffName.Text;
            DateTime dob = dateTimePickerDoB.Value;
            string address = textBoxAddress.Text;
            string phoneNum = textBoxPhone.Text;
            string bankAcc = textBoxBankAcc.Text;
            string staffLvl = comboBoxStaffLevel.Text;
            string dutyType = comboBoxDutyType.Text;
        }
    }
}
