using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SWEN_WEBSITE
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void b1_Click(object sender, EventArgs e)
        {
            string aa = TextBox.Text;
            string a = TextBox1.Text;
            string b = TextBox2.Text;
            string c = TextBox3.Text;
            string d = TextBox4.Text;
            string y = TextBox5.Text;
            string f = TextBox6.Text;
            string g = TextBox7.Text;
            string h = TextBox8.Text;
            string i = TextBox9.Text;
            string j = TextBox10.Text;
            string k = TextBox11.Text;
            string l = TextBox12.Text;
            string o = TextBox13.Text;

            CustomerInfo p = new CustomerInfo(aa, a, b, c, d, y, f, g, h, i, j, k, l, o);
            Database.InsertProductID(p);
        }
    }
}