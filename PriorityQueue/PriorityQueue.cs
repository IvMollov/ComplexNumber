using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PriorityQueue
{
    public class PriorityQueue<T> : IEnumerable<T> where T : IComparable<T>
    {
        private List<T> list;

        public PriorityQueue()
        {
            this.list = new List<T>();
        }

        public List<T> List { get; set; }

       public T this[int index]
        {
            get
            {
                if (list.Count == 0)
                {
                    throw new EmptyPriorityQueueException("Priority Queue is empty!");
                }
                else if(index >= list.Count)
                {
                    throw new IndexOutOfRangeException("Index is out of range!");
                }
                else
                {
                    return this.list[index];
                }             
            }
        }


        public void Enqueue(T item)
        {
            list.Add(item);
            int childNodeIndex = list.Count - 1;
            while (childNodeIndex > 0)
            {
                int parentNodeIndex = (childNodeIndex - 1) / 2;
                if (list[childNodeIndex].CompareTo(list[parentNodeIndex]) >= 0)
                {
                    break;
                }
                T temp = list[childNodeIndex];
                list[childNodeIndex] = list[parentNodeIndex];
                list[parentNodeIndex] = temp;
                childNodeIndex = parentNodeIndex;
            }
        }

        public T Peek()
        {
            if (list.Count == 0)
            {
                throw new EmptyPriorityQueueException("Priority Queue is empty!");
            }
            else
            {
                return list[0];
            }
        }

        public int Count()
        {
            return list.Count();
        }

        public T Dequeue()
        {
            if (list.Count == 0)
            {
                throw new EmptyPriorityQueueException("Priority Queue is empty!");
            }
            else
            {
                int lastIndex = list.Count - 1;
                T firstItem = list[0];
                list[0] = list[lastIndex];
                list.RemoveAt(lastIndex);
                lastIndex--;
                int parentNodeIndex = 0;

                while (true)
                {
                    int leftChildNodeIndex = 2 * parentNodeIndex + 1;
                    if (leftChildNodeIndex > lastIndex)
                    {
                        break;
                    }
                    int rigthChildNodeIndex = leftChildNodeIndex + 1;
                    if (rigthChildNodeIndex <= lastIndex && list[rigthChildNodeIndex].CompareTo(list[leftChildNodeIndex]) < 0)
                    {
                        leftChildNodeIndex = rigthChildNodeIndex;
                    }
                    if (list[parentNodeIndex].CompareTo(list[leftChildNodeIndex]) <= 0)
                    {
                        break;
                    }
                    T temp = list[parentNodeIndex];
                    list[parentNodeIndex] = list[leftChildNodeIndex];
                    list[leftChildNodeIndex] = temp;
                    parentNodeIndex = leftChildNodeIndex;
                }
                return firstItem;
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in list)
            {
                yield return item;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
