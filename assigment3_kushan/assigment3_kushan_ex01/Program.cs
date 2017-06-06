using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment3_kushan_ex01
{
    class Program
    {
        static void Main(string[] args)

        {
            var invoices = new[] {
                new Invoice(83, "Electric Sander", 7, 57.98),
                new Invoice(345, "power saw", 18, 99.99),
                new Invoice(564, "sledge hammer", 11, 21.50),
                new Invoice(784, "hammer", 76, 11.99),
                new Invoice(145, "lawn mower", 3, 79.50),
                new Invoice(254, "screwdriver", 106, 6.99),
                new Invoice(475, "jig saw", 21, 11.00),
                new Invoice(845, "wrench", 34, 7.50),
                
                
                
            };

            // display all employees
            Console.WriteLine("Original array:");
            foreach (var invoice in invoices)
            {
                Console.WriteLine(invoice);
            }

            // sort the invoice by partDec
            var nameSorted =
               from v in invoices
               orderby v.PartDescription select v;

            // header
            Console.WriteLine("\nSorted invoice by partTime:");

            foreach (var i in nameSorted) {
                Console.WriteLine(i);
            }

            // sort the invoice by partDec
            var priceSorted =
               from v in invoices
               orderby v.Price
               select v;

            // header
            Console.WriteLine("\nSorted invoice by price:");

            foreach (var i in priceSorted)
            {
                Console.WriteLine(i);
            }

            // sorting with price and description

            
            var quantityAndPartDesc =
               from v in (from data in invoices orderby data.Quntity select new { pr = data.Price, qu = data.Quntity }) select v;
               
               

            // header
            Console.WriteLine("\nSorted  by Quantity:");

            foreach (var i in quantityAndPartDesc)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nTotal Price :");
            foreach (var i in quantityAndPartDesc)
            {
                Console.WriteLine("total = " + i.pr*i.qu);
            }

            // attempt to display the first result of the above LINQ query

            Console.WriteLine("\n --d");


            foreach (var i in quantityAndPartDesc)
            {
                var total =   i.pr * i.qu;
                if (total >= 200 && total <= 500)
                {
                    Console.WriteLine(total);
                }
            }

            


            
        }

    }
}
