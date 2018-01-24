using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oliokotiotorert
{
    public class program
    {


        public static void Main(String[] args)
        {

            Circle c1 = new Circle(12);
            
            Console.WriteLine("The circle has radius of "
               + c1.getRadius() + " and area of " + c1.getArea());
            
            Circle c2 = new Circle(2.0);
            
            Console.WriteLine("The circle has radius of "
               + c2.getRadius() + " and area of " + c2.getArea());

            // cw (tab) (tab) -> console.writeline(); valmis rivi.
            Console.WriteLine(c1);
        }
    }
}

