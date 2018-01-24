using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oliokotiotorert
{
   public class Rectangle
    {
        private float length = 1.0f;
        private float width = 1.0f;

        public float getLength()
        {
            return length;
        }

        public void setLength(float newLength)
        {
            length = newLength;
        }

        public float getWidth()
        {
            return width;
        }

        public void setWidth(float newWidth)
        {
            width = newWidth;
        }

        public double getArea()
        {
            return length * width;
        }

        public double getPerimeter()
        {
            return length + length + width + width;
        }

        public string toString()
        {
            return "Rectangle [area= " + getArea() + ", Perimeter= " + getPerimeter() + "]";
        }


    }
}
