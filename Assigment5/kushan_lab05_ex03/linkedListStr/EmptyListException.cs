using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedListStr
{
    public class EmptyListException : Exception
    {
        public EmptyListException()
          : base("The list is empty")
        {
        }

        public EmptyListException(string name)
          : base(string.Format("The {0} is empty", (object)name))
        {
        }

        public EmptyListException(string exception, Exception inner)
          : base(exception, inner)
        {
        }
    }
}
