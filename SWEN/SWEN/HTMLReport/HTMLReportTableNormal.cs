using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HTMLReport
{
    class HTMLReportTableNormal
    {
        public ArrayList tableHeader { get; set; }
        public ArrayList tableBody { get; set; }
        public ArrayList cssRef { get; set; }
        public string reportHeader { get; set; }

        public HTMLReportTableNormal(string reportHeader)
        {
            this.reportHeader = reportHeader;
            tableHeader = new ArrayList();
            tableBody = new ArrayList();
            cssRef = new ArrayList();
        }

        public void addTableHeader(string header)
        {
            tableHeader.Add(header);
        }

        public void addTableHeader(ArrayList a)
        {
            tableHeader = a;
        }

        public void addTableHeader(params string[] content){
            foreach (string cont in content)
            {
                tableHeader.Add(cont);
            }
        }

        public void addCSS(string elm, params string[] info)
        {
            string css = elm+"{";
            foreach (string i in info)
            {
                css += i+";";
            }
            css += "}";

            cssRef.Add(css);
        }

        public void addContent(params string[] content)
        {
            ArrayList tableLine = new ArrayList();
            foreach(string cont in content){
                tableLine.Add(cont);
            }
            tableBody.Add(tableLine);
        }

        public string generateTable()
        {
            string output = "";
            
            //TABLE HEADERS
            output += "<table>";

            output += "<thead>";
            output += "<tr>";
            foreach (var value in tableHeader)
            {
                output += "<td>"+value+"</td>";
            }
            output += "</tr>";
            output += "</thead>";

            //TABLE BODY
            output += "<tbody>";

            foreach (ArrayList itemArr in tableBody)
            {
                output += "<tr>";

                foreach (var item in itemArr)
                {
                    output += "<td>"+item+"</td>";
                }

                output += "</tr>";
            }

            output += "</tbody>";

            output += "</table>";

            return output;
 
        }

        public string generateHTML(bool print)
        {
            string output = "";
            output += "<!DOCTYPE html>";
            output += "<html>";

            output += "<head>";
            output += "<title>"+reportHeader+"</title>";
            output += "<style type=\"\">";
            foreach (string css in cssRef)
            {
                output += css;
            }
            output += "</style>";
            

            if (print)
            {
                output += generatePrintCode();
            }
            output += "</head>";

            output += "<body>";
            output += "<div class=\"report-header\">"+reportHeader+"</div>";
            output += generateTable();
            output += "</body>";

            output += "</html>";

            return output;
        }

        private string generatePrintCode()
        {
            return "<script type=\"text/javascript\">window.print();</script> ";
        }




    }
}
