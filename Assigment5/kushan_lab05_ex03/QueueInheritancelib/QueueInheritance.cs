using linkedListStr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueInheritancelib
{
    public class QueueInheritance : List
    {
        public QueueInheritance()
          : base("queue")
        {
        }

        public void Enqueue(string dataValue)
        {
            this.InsertAtBack(dataValue);
        }

        public string Dequeue()
        {
            return this.RemoveFromFront();
        }
    }
}
