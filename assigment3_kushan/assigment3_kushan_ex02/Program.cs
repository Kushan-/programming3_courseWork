using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment3_kushan_ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            // populate a List of chars 
            var items = new List<char>();
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new List<char>();
            var random = new Random();

            for (int i = 0; i < 12; i++)
            {
                stringChars.Add(chars[random.Next(chars.Length)]);
            }

           // var finalString = new String(stringChars);
           // Console.WriteLine(stringChars);
            //Console.WriteLine(finalString);
            
            // display initial List
            Console.Write("items in char array:");
            foreach (var item in stringChars)
            {
                Console.Write($" {item}");
            }

            Console.WriteLine("\n"); // output end of line

            Console.WriteLine("Ascending Order :-");
            var aSort = stringChars.OrderBy(x => x);            // ascending
            foreach (var r in aSort) {
                Console.Write(r + "\t");
            }

            Console.WriteLine("\n"); // output end of line

            Console.WriteLine("Descending Order :-");
            var dSort = stringChars.OrderByDescending(x => x);  // descending
            foreach (var r in dSort)
            {
                Console.Write(r + "\t");
            }

            Console.WriteLine();
            Console.WriteLine("Distinct Element in Ascending order ");
            
            var rList = aSort.Distinct();
            foreach (var r in rList)
            {
                Console.Write(r + "\t");
            }






            Console.WriteLine(); // output end of line
        }
    }
}
