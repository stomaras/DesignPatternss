using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    class Program
    {
        /*
         * Documentation Builder Design Pattern 
         * 
         * What is the Builder Design Pattern?
         * The builder design pattern builds a complex object using many simple objects and using a step-by-step approach
         * The process of constructing a complex object should be generic so that the same construction process can be used to create
         * different representation of the same complex object.
         * 
         * So the builder design pattern is all about seperating the construction process from its representation. When the construction 
         * process of your object is very complex then only need to use to Builder Design Pattern.
         * 
         * In order to build a laptop, we have to use many small objects like LCD Display, USB Ports, Wireless, , Hard Drive, Battery, Memory, 
         * DVD/CD Reader, Keyboard, Plastic Case. So we have to assemble these small objects to build laptop complex objects.
         * 
         * Laptop Components :
         * 1) LCD Display
         * 2) Plastic Case
         * 3) Keyboard
         * 4) DVD/CD Reader
         * 5) Memory
         * 6) Battery
         * 7) Hard Drive
         * 
         * Generic Construction Process
         * 1) Plug the memory
         * 2) Plug the hard drive
         * 3) Plug the battery
         * 4) Plug the keyboard
         * ...  ... ...
         * ...  ... ...
         * 10) Cover the Laptop with plastic case.
         * 
         * So using the above process we can create different types of laptops such as a laptop with a 14inch screen or a 17inch screen.
         * Laptop with 4GB RAM or 8GB RAM.So like these we can create different types of laptops.So all the laptop creations will follow 
         * the same generic process.
         * 
         * Suppose we want to develop an application for dislaying the reports.The reports we need to display either in excel or in pdf format.
         * That means , we have two types of representation of my reports.The reports we need to display either in Excel or PDF Format.
         * That means we have two types or representation of my reports.
         * 
         * Request For A Report
         *          |
         *          |
         *        Report Type
         * |                            |
         * |                            |
         * |                            |
         * 
         * Excel                         PDF
         * 
         * Create New Report        Create New Report
         * Set Report Type Excel    Set Report Type as pdf
         * Set Report Header Excel  Set Report Header as pdf
         * Set Report Content Excel Set Report Content as pdf 
         * Set Report Footer Excel  Set Report Footer as pdf
         * |                        |
         * |                        |
         * |                        |
         * Get the Report           Get the Report
         * 
         * A) Create Different Representations : 1) PDF Report
         *                                       2) Excel Report
         * 
         * B) Same Construction Process : 1) Create a new Report.
         *                                2) Set Report Type.
         *                                3) Set Report Header.
         *                                4) Set Report Content.
         *                                5) Set Report Footer.
         *                                6) Get the Report.
         *                   
         * In order to seperate the construction process 
         * from its representation,
         * the builder design pattern involve four components
         *                   
         *                   1) Builder : The Builder is an interface that defines all the steps which are used to make the concrete product.
         *                   2) Concrete Builder: The ConcreteBuilder class implements the Builder Interface and provides implementation to all 
         *                                        the abstract methods. The Concrete Builder is responsible for constructs and assembles the individual 
         *                                        parts of the product by implementing the Builder Interface.It also defines and tracks the 
         *                                        representation it creates.
         *                   3) Director: The Director takes those individual processes from the Builder and defines the sequence to build the product.
         *                   4) Product: The Product is a class and we want to create this product object using the builder design pattern.
         *                               This class defines different parts that will make the product.
         *                   
         *                   
         *                   
         *                   
         *                   
         *                   
         * 
         * 
         * 
         * 
         */
        static void Main(string[] args)
        {
            // Client Code
            Report report;
            ReportDirector reportDirector = new ReportDirector();

            // Construct and display Reports
            PDFReport pdfReport = new PDFReport();
            report = reportDirector.MakeReport(pdfReport);
            report.DisplayReport();

            Console.WriteLine("--------------------");
            ExcelReport excelReport = new ExcelReport();
            report = reportDirector.MakeReport(excelReport);
            report.DisplayReport();
            Console.ReadKey();
        }
    }
}
