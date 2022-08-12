using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample1
{
    /*
     * This class is having one generic method. MakeReport which wll take the report
     * Builder instance as an input parameter and then create and return a particular
     * report object.
     * 
     * Once we have the Director and ConcreteBuilder , now we can use them in the Main 
     * Method to create different types of Reports.
     * 
     * In Director we inject ReportBuilder Object
     */
    public class ReportDirector
    {
        public Report MakeReport(ReportBuilder reportBuilder)
        {
            reportBuilder.CreateNewReport();
            reportBuilder.SetReportType();
            reportBuilder.SetReportHeader();
            reportBuilder.SetReportContent();
            reportBuilder.SetReportFooter();

            return reportBuilder.GetReport();
        }
    }
}
