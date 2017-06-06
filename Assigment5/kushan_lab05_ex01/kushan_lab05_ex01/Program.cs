using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kushan_lab05_ex01;
using kushan_lab05_ex01_Test_;

namespace kushan_lab05_ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List(); // create List container

            // create data to store in List
            double elem1 = 1.00, elem2 = 1.50, elem3 = 2.00, elem4 = 2.50;

            // use List insert methods       
            list.InsertAtBack(elem1);
            list.Display();
            list.InsertAtBack(elem2);
            list.Display();
            list.InsertAtBack(elem3);
            list.Display();
            list.InsertAtBack(elem4);
            list.Display();
            list.Count();
            //  Console.Out.WriteLine("Enter the element to be searched: ");
            double SearchDoub = 1.50;
            //Convert.ToDouble(Console.ReadLine());
            list.Search(SearchDoub);

            Console.ReadLine();

            // remove data from list and display after each removal
            try
            {
                double removedObject = list.RemoveFromFront();
                Console.WriteLine($"{removedObject} removed");
                list.Display();

                removedObject = list.RemoveFromFront();
                Console.WriteLine($"{removedObject} removed");
                list.Display();

                removedObject = list.RemoveFromBack();
                Console.WriteLine($"{removedObject} removed");
                list.Display();

                removedObject = list.RemoveFromBack();
                Console.WriteLine($"{removedObject} removed");
                list.Display();
            }
            catch (EmptyListException emptyListException)
            {
                Console.Error.WriteLine($"\n{emptyListException}");
            }
            
        }
    }
}
