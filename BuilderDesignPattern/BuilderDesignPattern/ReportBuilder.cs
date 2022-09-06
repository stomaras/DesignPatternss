using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    /*
     * Create the bstract builder class, and this class provides the blueprint to create different types of beverages.
     * That means the subclasses are going to implement this ReportBuilder abstract class.
     * Notice we have four abstract methods. So each subclasses of ReportBuilder will need to implement those methods 
     * in order to properly build a report.Now we need to create a few concrete builder classes by implementing the above 
     * ReportBuilder Interface.
     */
    public abstract class ReportBuilder
    {
        protected Report reportObject;

        public abstract void SetReportType();
        public abstract void SetReportHeader();
        public abstract void SetReportContent();
        public abstract void SetReportFooter();

        public void CreateNewReport()
        {
            reportObject = new Report();
        }

        public Report GetReport()
        {
            return reportObject;
        }
    }
}
