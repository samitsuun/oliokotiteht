using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oliokotiotorert
{
  public class SimpleCircle
    {
        private double radius = 1.0;
        private string color = "red";

        public SimpleCircle(double radius)
        {
            this.radius = radius;
        }

        public double getRadius()
        {
            return radius;
        }

        public void setRadius(double radius)
        {
            this.radius = radius;
        }

        public double getArea()
        {
            return radius * radius * Math.PI;
        }

        public double getCircumference()
        {
            return radius * 2 * Math.PI;
        }

        public string toString()
        {
            return "Rectangle [radius= " + radius + "]" + "\n" + "[area= " + getArea() + "]" + "\n" + "[circumference= " + getCircumference() + "]";
        }
    }
}
