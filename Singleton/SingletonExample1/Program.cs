using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * We have wrapped these two methods as actions in parallele invoke
             * This violates singleton design pattern
             */
            Parallel.Invoke(
                () => PrintEmployeeDetails(),
                () => PrintStudentDetails()
                );
            PrintStudentDetails();
            PrintEmployeeDetails();

        }

        private static void PrintEmployeeDetails()
        {
            /*
                         * Assuming Singleton is created from employee class
                         * we refer to the GetInstance property from the Singleton Class
                         */
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("This is from Employee");
        }

        private static void PrintStudentDetails()
        {
            /*
                         * Assuming Singleton is created from student class
                         * we refer to the GetInstance Property from the Singleton Class
                         */
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintDetails("This is from Student");
        }
    }
}

#region ToDo
/*
 * Lazy vs Eager Loading in Singleton
 * Static Class Vs Singleton
 * Exception Logging using Singleton Design Pattern
 * 
 */
#endregion
