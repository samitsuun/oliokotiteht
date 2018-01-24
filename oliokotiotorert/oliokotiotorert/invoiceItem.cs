using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oliokotiotorert
{
   public class invoiceItem
    {
        private string id;
        private string desc;
        private int qty;
        private double unitPrice;

        public invoiceItem()
        {
            id = "item";
            desc = "description";
            qty = 1;
            unitPrice = 10;
        }

        public string getId()
        {
            Console.WriteLine("Item id: ");
            id = Console.ReadLine();
            return id;
        }

        public string getDesc()
        {
            Console.WriteLine("Item desc: ");
            desc = Console.ReadLine();
            return desc;
        }

        public int getQty()
        {
            return qty;
        }

        public void setQty(int newQty)
        {
            qty = newQty;
        }

        public double getUnitPrice()
        {
            return unitPrice;
        }

        public void setUnitPrice(double newUnitPrice)
        {
            unitPrice = newUnitPrice;
        }

        public double getTotal()
        {
            return unitPrice * qty;
        }

        public string toString()
        {
            return "InvoiceItem" + "\n" + "\n" + "id: " + id + "\n" + "Description: " + desc + "\n" + "Quantity: " + qty + "\n" + "UnitPrice: " + unitPrice + "\n" + "Total: " + getTotal() + "\n";
        }
    }
}
