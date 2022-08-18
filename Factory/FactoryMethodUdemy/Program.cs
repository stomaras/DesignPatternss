using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodUdemy
{
    internal class Program
    {

        public enum CoordinateSystem
        {
            Cartesian,
            Polar
        }

        public static class PointFactory
        {
            public static Point NewCartesianProduct(double x, double y)
            {
                return new Point(x, y);
            }

            public static Point NewPolarPoint(double rho, double theta)
            {
                return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
            }
        }

        public class Point
        {
           


            private double x, y;
           
            public Point(double a, double b)
            {
                x = a;
                y = b;
            }
        }
        static void Main(string[] args)
        {
            var point = PointFactory.NewPolarPoint(1.0, Math.PI / 2);
        }
    }
}

/*
 * Notes :  
 * 
 * Object Creation logic becomes too convoluted
 * Constructor is not descriptive
 * 
 * Factory ( A component responsible solely for the wholesale creation of objects)
 * 
 * Factory Method
 * 
 * 
 */
