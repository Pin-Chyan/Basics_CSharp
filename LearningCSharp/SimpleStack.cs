using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
    class SimpleStack
    {
        public void stackSimple()
        {
            // Creates and initializes a new Stack.
            Stack myStack = new Stack();
            myStack.Push("Hello");
            myStack.Push("World");
            myStack.Push("!");

            // Displays the properties and values of the Stack.
            Console.WriteLine("myStack");
            Console.WriteLine("\tCount: {0}", myStack.Count);
            Console.Write("\tValues: ");
            PrintValues(myStack);
        }

        public void PrintValues(IEnumerable myCollection)
        {
            foreach(Object obj in myCollection)
                Console.Write(" {0}", obj);
            Console.WriteLine();
        }
    }
}
