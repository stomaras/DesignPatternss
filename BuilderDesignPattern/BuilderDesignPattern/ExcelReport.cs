using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class ExcelReport : ReportBuilder
    {
        public override void SetReportContent()
        {
            reportObject.ReportContent = " Excel Content Section";
        }

        public override void SetReportFooter()
        {
            reportObject.ReportFooter = " Excel Footer";
        }

        public override void SetReportHeader()
        {
            reportObject.ReportHeader = " Excel Header ";
        }

        public override void SetReportType()
        {
            reportObject.ReportType = "Excel";
        }
    }
}
