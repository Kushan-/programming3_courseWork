using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kushan_lab05_ex01_Test_;
using kushan_lab05_ex02;

namespace kushan_lab05_ex02_Test_
{
    class Program
    {
        static void Main(string[] args)
        {
            StackInheritence stack = new StackInheritence();

            // create objects to store in the stack
            double value1 = 1.23;
            double value2 = 2.36;
            double value3 = 4.56;
            double value4 = 5.36;

            // use method Push to add items to stack
            Console.WriteLine("Pushing elements");
            stack.Push(value1);
            stack.Display();
            stack.Push(value2);
            stack.Display();
            Console.WriteLine("Top element:- ");
            Console.WriteLine(stack.Peek());

            stack.Push(value3);
            stack.Push(value4);
            stack.Display();

            // remove items from stack
            try
            {


                double removedObject = stack.Pop();
                Console.WriteLine($"{removedObject} popped");
                stack.Display();

            }
            catch (EmptyListException emptyListException)
            {
                // if exception occurs, write stack trace
                Console.Error.WriteLine(emptyListException.StackTrace);
            }
        }
    }
}
