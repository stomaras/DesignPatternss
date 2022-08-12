using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample1
{
    public class PdfReport : ReportBuilder
    {
        public override void SetReportContent()
        {
            Console.WriteLine("PDF Content");
        }

        public override void SetReportFooter()
        {
            Console.WriteLine("PDF Footer");
        }

        public override void SetReportHeader()
        {
            Console.WriteLine("PDF Header");
        }

        public override void SetReportType()
        {
            Console.WriteLine("PDF Type");
        }
    }
}
