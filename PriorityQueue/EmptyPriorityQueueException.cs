using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueue
{
    class EmptyPriorityQueueException : Exception
    {
        public EmptyPriorityQueueException(string message)
        {
            message = "Priority Queue is empty!";
        }
    }
}
