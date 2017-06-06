using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kushan_lab05_ex01_Test_;


namespace kushan_lab05_ex02
{
    public class StackInheritence:List
    {
        // pass name "stack" to List constructor
        public StackInheritence() : base("stack") { }

        // place dataValue at top of stack by inserting 
        // dataValue at front of linked list
        public void Push(double dataValue)
        {
            InsertAtFront(dataValue);
        }

        // remove item from top of stack by removing
        // item at front of linked list
        public double Pop()
        {
            return RemoveFromFront();
        }

        public double Peek()
        {
            return peek();
        }
    }
}
