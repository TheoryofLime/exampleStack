using System;

namespace exampleStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack <string> newStack= new Stack<string>();
            // add items
            newStack.Push("A");
            newStack.Push("B");
            newStack.Push("C");
            newStack.Push("D");
            newStack.Push("E");
            // check for item and display
            Console.WriteLine(newStack.Contains("C"));
            // remove an item
            newStack.Pop();
            // count 
            Console.WriteLine(newStack.Count);
            // display all
            foreach (string s in newStack)
            {
                Console.WriteLine(s);
            }
        }
    }
}
