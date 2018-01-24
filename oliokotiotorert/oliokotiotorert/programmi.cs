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

            ///////////////////////
            Console.WriteLine("\n");


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

            ////////////////////////////////////
            Console.WriteLine("\n");


            Date d1 = new Date();
            Console.WriteLine(d1.getDay() + "/" + d1.getMonth() + "/" + d1.getYear());

            Date d2 = new Date(15, 8, 2018);
            Console.WriteLine(d2.getDay() + "/" + d2.getMonth() + "/" + d2.getYear());

            Date d3 = new Date();
            d3.setDay(3);
            d3.setMonth(8);
            d3.setYear(1995);
            Console.WriteLine(d3.toString());

            //////////////////////////////////
            Console.WriteLine("\n");


            Account a1 = new Account();
            Console.WriteLine(a1.toString());
            Console.WriteLine();

            Account a2 = new Account();
            a2.setBalance(1000);
            //a2.Balance = a2.credit(500);
            a2.debit(400);
            a2.transferTo(a2, 400);

            Console.WriteLine(a2.toString());

            ////////////////////////////////////
            Console.WriteLine("\n");


            invoiceItem i1 = new invoiceItem();
            i1.getId();
            i1.getDesc();
            Console.WriteLine(i1.toString());
            Console.WriteLine();

            invoiceItem i2 = new invoiceItem();
            i2.getId();
            i2.getDesc();
            i2.setQty(3);
            i2.setUnitPrice(100);
            Console.WriteLine(i2.toString());

            ////////////////////////////////
            Console.WriteLine("\n");


            Employee E1 = new Employee();
            E1.getFirstName();
            E1.getLastName();
            Console.WriteLine();
            Console.WriteLine(E1.toString());
            Console.WriteLine();

            Employee E2 = new Employee();
            E2.getFirstName();
            E2.getLastName();
            E2.setSalary(1500);
            E2.raiseSalary(500);
            Console.WriteLine();
            Console.WriteLine(E2.toString());

            //////////////////////////////////////
            Console.WriteLine("\n");


            Rectangle R1 = new Rectangle();
            Console.WriteLine(R1.toString());

            Rectangle R2 = new Rectangle();
            R2.setLength(15);
            R2.setWidth(10);
            Console.WriteLine(R2.toString());

            ////////////////////////////////////
            Console.WriteLine("\n");

            SimpleCircle C1 = new SimpleCircle(21);
            C1.setRadius(13);
            Console.WriteLine(C1.toString());
            Console.WriteLine();

            ////////////////////////////////////
            Console.WriteLine("\n");
        }
    }
}

