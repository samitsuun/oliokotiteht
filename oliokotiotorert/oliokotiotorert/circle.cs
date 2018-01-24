using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oliokotiotorert
{
    public class Circle
    {  

        private double radius;
        private String color;

        
        public Circle()
        {
            radius = 1.0;
            color = "red";
        }

        public Circle(double r)
        {
            radius = r;
            color = "red";
        }
        
        public double getRadius()
        {
            return radius;
        }
        
        public double getArea()
        {
            return radius * radius * Math.PI;
        }

        public override string ToString()
        {
            return radius + " " + color;
        }
    }
}
