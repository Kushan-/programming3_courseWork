using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment3_kushan_ex01
{
    class Invoice
    {
        public int  PartNumber { get; } // read-only auto-implemented property
        public string PartDescription { get; } // read-only auto-implemented property
        public int Quntity { get; } // read-only auto-implemented property
        public double Price { get; }

        //constructor
        public Invoice( int partNumber, String partDescription, int quantity, double price)
        {
            PartNumber = partNumber;
            PartDescription = partDescription;
            Quntity = quantity;
            Price = price;
        }



        public override string ToString() {
            return string.Format("{0, -5} \t \t {1,15} \t \t {2, 5} \t \t {3,5}", PartNumber, PartDescription, Quntity, Price);
        }
            
         

    }

}
