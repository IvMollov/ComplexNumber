using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue<int> pr = new PriorityQueue<int>();
            pr.Enqueue(13);
            pr.Enqueue(9);
            pr.Enqueue(4);
            pr.Enqueue(7);
            pr.Enqueue(5);
            pr.Enqueue(11);
            pr.Enqueue(43);
            pr.Enqueue(23);
            pr.Enqueue(76);
            pr.Enqueue(43);
            try
            {
                int peek = pr.Peek();
                Console.WriteLine("First node is: {0}", peek);
                Console.WriteLine("\nPrint hole priority queue:");
                Print(pr);

                Console.WriteLine("Let's delete first node!");
                int delete = pr.Dequeue();
                Console.WriteLine("We have deleted {0}", delete);
                Console.WriteLine("Let's delete another node!");
                int exc = pr.Dequeue();
                Console.WriteLine("We have deleted {0}", exc);
                Print(pr);
            }
            catch(EmptyPriorityQueueException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

        public static void Print(PriorityQueue<int> list)
        {
            StringBuilder text = new StringBuilder();
            foreach (var item in list)
            {
                text.Append(item.ToString() + " ");
            }
           
            Console.WriteLine(text.ToString());
        }
    }
}
