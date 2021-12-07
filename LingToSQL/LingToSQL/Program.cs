using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LingToSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthDataContext DC = new NorthDataContext();
            var x1 = from x in DC.Customers select x;
            foreach (var y in x1)
            {
                Console.WriteLine(y.CompanyName);
            }
            Order_Detail p = new Order_Detail();
            p.OrderID = 10248;
            p.ProductID = 2;
            p.Quantity = 12;
            Brisi(10248, 2);
            DC.Order_Details.InsertOnSubmit(p);
            DC.SubmitChanges();
            Posodobi(p, DC);
            Console.Read();
        }
        private static void Brisi(int idN, int id)
        {
            NorthDataContext DC = new NorthDataContext();
            try
            {
                var x = (from a in DC.Order_Details
                         where a.OrderID == idN && a.ProductID == id
                         select a).FirstOrDefault();
                DC.Order_Details.DeleteOnSubmit(x);
                DC.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        private static void Posodobi(Order_Detail od, NorthDataContext dc)
        {
            try
            {
                var x = (from a in dc.Order_Details
                         where a.OrderID == od.OrderID && a.ProductID == od.ProductID
                         select a).FirstOrDefault();
                if (x!=null)
                {
                    x.Quantity = od.Quantity;
                    dc.SubmitChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
