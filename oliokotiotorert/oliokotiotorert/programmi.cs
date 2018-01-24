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

            timma t1 = new timma(1, 3, 5);
            Console.WriteLine(t1.getHour() + ":" + t1.getMinute() + ":" + t1.getSecond());

            timma t2 = new timma();
            t2.setHour(5);
            t2.SetMinute(1);
            t2.SetSecond(10);
            t2.NextSecond();
            t2.NextSecond();
            t2.PreviousSecond();
            Console.WriteLine(t2.toString());

            Date d1 = new Date();
            Console.WriteLine(d1.getDay() + "/" + d1.getMonth() + "/" + d1.getYear());

            Date d2 = new Date(15, 8, 2018);
            Console.WriteLine(d2.getDay() + "/" + d2.getMonth() + "/" + d2.getYear());

            Date d3 = new Date();
            d3.setDay(3);
            d3.setMonth(8);
            d3.setYear(1995);
            Console.WriteLine(d3.toString());



        }
    }
}

