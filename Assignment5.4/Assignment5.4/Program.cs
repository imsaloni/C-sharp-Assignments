using System;
using System.Collections;

class Fourth
{

    static public void Main()
    {

        Stack my_stack = new Stack();
        my_stack.Push("one");
        my_stack.Push("two");
        my_stack.Push("three");
        my_stack.Push("four");

        Console.WriteLine("Total elements present in" + " my_stack: {0}", my_stack.Count);

        my_stack.Pop();
        Console.WriteLine("Total elements present in " + "my_stack: {0}", my_stack.Count);


        my_stack.Clear();

        // After Pop method
        Console.WriteLine("Total elements present in " +
                      "my_stack: {0}", my_stack.Count);

    }
}