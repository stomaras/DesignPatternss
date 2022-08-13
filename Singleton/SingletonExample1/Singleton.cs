using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample1
{
    
    /*
     * 1) Sealed restrict the inheritance from nested classes
     */
    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;
        private static readonly object obj = new object();

        /*
         * 2) public property is used to return only one instance of the class
         *    leveraging on the private properrty
         *    Lazy Initialization works perfect in single thread environmetn
         *    if multiple threads are invoking this property at the same point of time
         *    there is a chance we have multiple instance object
         */
        public static Singleton GetInstance
        {
            get
            {
                /*
                * Only one thread which arrives earlier succeeds to enter this code block
                */
                if (instance is null)
                {
                    
                    lock (obj)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }
                return instance;

            }
        }
        /*
         * 3) Private Constructor ensures that object is not instantiated
         *    other than with in the class itself
         */
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }

        /*
         * 4) Public method which can be invoked through the singleton instance
         */
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }


        // nested class
        //public class DerivedSingleton : Singleton
        //{

        //}
    }
}
