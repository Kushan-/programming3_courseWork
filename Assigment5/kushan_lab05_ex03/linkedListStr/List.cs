using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedListStr
{
    public class List
    {
        private ListNode firstNode;
        private ListNode lastNode;
        private string name;

        public List(string listName)
        {
            this.name = listName;
            this.firstNode = this.lastNode = (ListNode)null;
        }

        public List()
          : this("list")
        {
        }

        public void InsertAtFront(string insertItem)
        {
            if (this.IsEmpty())
                this.firstNode = this.lastNode = new ListNode(insertItem);
            else
                this.firstNode = new ListNode(insertItem, this.firstNode);
        }

        public void InsertAtBack(string insertItem)
        {
            if (this.IsEmpty())
                this.firstNode = this.lastNode = new ListNode(insertItem);
            else
                this.lastNode = this.lastNode.Next = new ListNode(insertItem);
        }

        public string RemoveFromFront()
        {
            if (this.IsEmpty())
                throw new EmptyListException(this.name);
            string data = this.firstNode.Data;
            this.firstNode = this.firstNode != this.lastNode ? this.firstNode.Next : (this.lastNode = (ListNode)null);
            return data;
        }

        public string RemoveFromBack()
        {
            if (this.IsEmpty())
                throw new EmptyListException(this.name);
            string data = this.lastNode.Data;
            if (this.firstNode == this.lastNode)
            {
                this.firstNode = this.lastNode = (ListNode)null;
            }
            else
            {
                ListNode listNode = this.firstNode;
                while (listNode.Next != this.lastNode)
                    listNode = listNode.Next;
                this.lastNode = listNode;
                listNode.Next = (ListNode)null;
            }
            return data;
        }

        public string Search()
        {
            string str1 = "";
            try
            {
                if (this.IsEmpty())
                    throw new EmptyListException(this.name);
                string str2 = Console.ReadLine();
                for (ListNode listNode = this.firstNode; listNode.Next != this.lastNode; listNode = listNode.Next)
                {
                    if (listNode.Data.Equals(str2))
                    {
                        str1 = string.Format("The {0:f2} is present ", (object)str2);
                        break;
                    }
                    str1 = string.Format("The {0:f2} is not present", (object)str2);
                }
                return str1;
            }
            catch (Exception ex)
            {
                Console.WriteLine((object)ex);
                throw;
            }
        }

        public string Count()
        {
            if (this.IsEmpty())
                throw new EmptyListException(this.name);
            int num = 1;
            ListNode listNode = this.firstNode;
            while (!(listNode.Data == this.lastNode.Data))
            {
                ++num;
                listNode = listNode.Next;
                if (listNode.Next == null)
                    break;
            }
            return num.ToString();
        }

        public bool IsEmpty()
        {
            return this.firstNode == null;
        }

        public void Display()
        {
            if (this.IsEmpty())
            {
                Console.WriteLine(string.Format("Empty {0}", (object)this.name));
            }
            else
            {
                Console.Write(string.Format("The {0} is: ", (object)this.name));
                for (ListNode listNode = this.firstNode; listNode != null; listNode = listNode.Next)
                    Console.Write(string.Format("{0} ", (object)listNode.Data));
                Console.WriteLine("\n");
            }
        }

        public string Top()
        {
            return this.firstNode.Data;
        }
    }





   
}
