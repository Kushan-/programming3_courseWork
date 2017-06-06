using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kushan_lab05_ex01_Test_
{
    public class List
    {

        private ListNode firstNode;
        private ListNode lastNode;
        private string name; // string like "list" to display

        // construct empty List with specified name
        public List(string listName)
        {
            name = listName;
            firstNode = lastNode = null;
        }

        // construct empty List with "list" as its name 
        public List() : this("list") { }

        // Insert double at front of List. If List is empty, 
        // firstNode and lastNode will refer to same double.
        // Otherwise, firstNode refers to new node.
        public void InsertAtFront(double insertItem)
        {
            if (IsEmpty())
            {
                firstNode = lastNode = new ListNode(insertItem);
            }
            else
            {
                firstNode = new ListNode(insertItem, firstNode);
            }
        }

        // Insert double at end of List. If List is empty, 
        // firstNode and lastNode will refer to same double.
        // Otherwise, lastNode's Next property refers to new node.
        public void InsertAtBack(double insertItem)
        {
            if (IsEmpty())
            {
                firstNode = lastNode = new ListNode(insertItem);
            }
            else
            {
                lastNode = lastNode.Next = new ListNode(insertItem);
            }
        }

        // remove first node from List
        public double RemoveFromFront()
        {
            if (IsEmpty())
            {
                throw new EmptyListException(name);
            }

            double removeItem = firstNode.Data; // retrieve data

            // reset firstNode and lastNode references
            if (firstNode == lastNode)
            {
                firstNode = lastNode = null;
            }
            else
            {
                firstNode = firstNode.Next;
            }

            return removeItem; // return removed data
        }

        // remove last node from List
        public double RemoveFromBack()
        {
            if (IsEmpty())
            {
                throw new EmptyListException(name);
            }

            double removeItem = lastNode.Data; // retrieve data

            // reset firstNode and lastNode references
            if (firstNode == lastNode)
            {
                firstNode = lastNode = null;
            }
            else
            {
                ListNode current = firstNode;

                // loop while current.Next is not lastNode
                while (current.Next != lastNode)
                {
                    current = current.Next; // move to next node
                }

                // current is new lastNode
                lastNode = current;
                current.Next = null;
            }

            return removeItem; // return removed data
        }

        public double Search(double val)
        {
            ListNode current = firstNode;
            //  ListNode last = lastNode;
            if (IsEmpty())
            {
                throw new EmptyListException(name);
            }
            else
            {
                while (current != null)
                {
                    if (current.Data.Equals(val))
                    {
                        Console.Out.WriteLine("Element " + val + " Found");
                        break;

                    }
                    else
                    {
                        current = current.Next; // move to next node

                    }


                }
            }
            // loop while current.Next is not lastNode

            return lastNode.Data;

        }

        public int Count()
        {
            int count = 0;
            if (IsEmpty())
            {
                throw new EmptyListException(name);
            }
            else
            {
                for (ListNode j = firstNode; j != null; j = j.Next)
                {
                    count++;
                }
                Console.WriteLine("Tne number of elements in the list is " + count);
            }

            return count;
        }

        // return true if List is empty
        public bool IsEmpty()
        {
            return firstNode == null;
        }
        //display first element

        public double peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine($"Empty {name}");
            }
                ListNode top = firstNode;
               
            return top.Data;
        }

        // output List contents
        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine($"Empty {name}");
            }
            else
            {
                Console.Write($"The {name} is: ");

                ListNode current = firstNode;

                // output current node data while not at end of list
                while (current != null)
                {
                    Console.Write($"{current.Data} ");
                    current = current.Next;
                }

                Console.WriteLine("\n");
            }
        }
    }
}
