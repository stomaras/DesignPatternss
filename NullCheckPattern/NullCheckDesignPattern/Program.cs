using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullCheckDesignPattern
{
    /*
     * When Component A uses component B, it typically assumes 
     * that B is non-null
     * - You inject B, not B? or some Option<B>
     * - You do not check for null (?.) on every call
     * 
     * Null Object Design Pattern is all about building an Object 
     * which conforms to the required interface , satisfies some sort of dependency
     * requirement, for example, but does absolutely nothing at all
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            var cb = new ContainerBuilder();
        }
    }
}
