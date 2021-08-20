using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
    class SimpleQueue
    {
        public void queueSimple()
        {
            // Creates and initializes a new Queue.
            Queue myQ = new Queue();
            myQ.Enqueue("Hello");
            myQ.Enqueue("World");
            myQ.Enqueue("!");

            Console.WriteLine("myQ");
            Console.WriteLine("\tCount: {0}", myQ.Count);
            Console.Write("\tValues:");
            PrintValues(myQ);
        }

        public void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.Write(" {0}", obj);
            Console.WriteLine();
        }
    }
}
