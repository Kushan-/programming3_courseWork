using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QueueInheritancelib;
using linkedListStr;

namespace kushan_lab05_ex03
{
    class Program
    {
        static void Main(string[] args)
        {

            QueueInheritance queue = new QueueInheritance();
            string str1 = "hey";
            string str2 = "hi";
            string str3 = "hello";
            string str4 = "there";

            //use method Enqueue to add items to queue
            queue.Enqueue(str1);
            queue.Display();
            queue.Enqueue(str2);
            queue.Display();
            queue.Enqueue(str3);
            queue.Display();
            queue.Enqueue(str4);
            queue.Display();

            // use method Dequeue to remove items from queue
            string removedObject = null;

            // remove items from queue
            try
            {

                removedObject = queue.Dequeue();
                Console.WriteLine($"{removedObject} dequeued");
                queue.Display();

            }
            catch (EmptyListException emptyListException)
            {
                // if exception occurs, write stack trace
                Console.Error.WriteLine(emptyListException.StackTrace);
            }


        }
    }
}
