using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedListStr
{
    class ListNode
    {
        
            public string Data { get; private set; }

            public ListNode Next { get; set; }

            public ListNode(string dataValue)
              : this(dataValue, (ListNode)null)
            {
            }

            public ListNode(string dataValue, ListNode nextNode)
            {
                this.Data = dataValue;
                this.Next = nextNode;
            }
        
    }
}
