using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryKudvenkat
{
    /*
     * Factory pattern is one of the most used design patterns
     * in real world apps.
     * 
     * Factory pattern creates object without exposing the creation logic 
     * to the client and refer to newly object using a common interface.
     * 
     * Choose Factory Pattern when :
     * 1) The Object needs to be extended to subclasses
     * 2) The classes does not know what exact sub-classes it has to create
     * 3) The Product Implementation tend to change over time and Client remains unchnaged
     * 
     * Business Requirement 
     * Differentiate employees as permanent and contract and segregate their pay scales
     * as well as bonus based on their employee types.
     * 
     * 
     * Client uses Factory creates Product
     * 
     *
     *
     */
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
