using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample1
{
    /*
     * This is our product class and within this class, we define the attributes
     * (such as ReportHeader, ReportFooter and ReportContent) which are common to create
     * a report. We also define one method DisplayReport to display the report details
     * in the console.
     */
    public class Report
    {
        public string ReportType { get; set; }
        public string ReportHeader { get; set; }
        public string ReportFooter { get; set; }
        public string ReportContent { get; set; }

        public void DisplayReport()
        {
            Console.WriteLine("Report Type :" + ReportType);
            Console.WriteLine("Report Header :" + ReportHeader);
            Console.WriteLine("Report Content :" + ReportContent);
            Console.WriteLine("Footer :" + ReportFooter);
        }
    }
}
