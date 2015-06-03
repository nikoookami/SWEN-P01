using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HTMLReport;
using System.IO;
using SWEN_Assignment_3.Classes;
using SWEN_Assignment_3.Classes.Reports;
namespace SWEN_Assignment_3.Booking
{
    public partial class PrintInvoice : Form
    {
        public PrintInvoice()
        {
            InitializeComponent();
        }
        HTMLReportTableNormal n;
        public int bookingID;
        public Double noofalco;
        public Double noofnonalco;
        public Double pricealco;
        public Double pricenonalco;
        public Double ttdrinks;
        public Double ttrooms;
        public Double ttprice;
        public Double ttpricegst;

        
        

        private void button1_Click(object sender, EventArgs e)
        {
            wbReportContainer.DocumentText = n.generateHTML(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            wbReportContainer.DocumentText = n.generateHTML(true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sfdDocSave.Filter = "HTML documents (*.html)|*.html";
            sfdDocSave.ShowDialog();
        }

        private void PrintInvoice_Load(object sender, EventArgs e)
        {
            n = new HTMLReportTableNormal("Invoice");
            //n.addTableHeader("UserID", "Username", "Password", "Address");
            //n.addTableHeader("Invoice" + Environment.NewLine);
            BOOK toprint = new BOOK();
            toprint = DBManager.getbookingByID(bookingID);
            Guest toprint1 = new Guest();
            toprint1 = DBManager.getGuestByID(toprint.GuestID);
            Room toprint2 = new Room();
            //toprint2 = DBManager;
            
            
            //n.addTableHeader("Invoice");
            n.addContent("Name: ", toprint1.Name);
            double totalalco = noofalco * pricealco;
            double totalnonalco = noofnonalco * pricenonalco;
            n.addContent("Check In Date: ",toprint.Check_In_Date,"    Check Out Date: ",toprint.Check_Out_Date);
            n.addContent("No of Rooms: ",Convert.ToString(toprint.No_Of_Rooms));
            n.addContent("No of Alcoholic Drinks Consumed: ",Convert.ToString(noofalco),"Total price: ",Convert.ToString(totalalco));
            n.addContent("No of Non-alcoholic Drinks Consumed: ", Convert.ToString(noofnonalco), "Total price: ", Convert.ToString(totalnonalco));
            n.addContent("Total Price of Drinks: "+ttdrinks);
            n.addContent("Total Price of Rooms: "+ttrooms);
            n.addContent("Total Price: "+ttprice);
            n.addContent("Total Price (incl. of GST): ",Convert.ToString(ttpricegst));
           
            //
            n.addCSS("body,html", "font-family:'Impact'");
           // n.addCSS("table", "width:100%", "border:1px solid #000000");
            n.addCSS("thead>tr>td", "font-weight:600", "text-align:center", "font-size:1.2em");
          //  n.addCSS("td", "border: 1px solid #000000");
           // n.addCSS(".report-header", "font-family:'Segoe UI Light'", "font-size:1.5em", "text-align:center", "margin-bottom:10px");
        }

        private void sfdDocSave_FileOk(object sender, CancelEventArgs e)
        {
            string name = sfdDocSave.FileName;
            StreamWriter w = new StreamWriter(name);
            w.Write(n.generateHTML(false));
            w.Close();
        }

    }
}
