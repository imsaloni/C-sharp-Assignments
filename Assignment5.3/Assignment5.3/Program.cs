using System;
using System.Collections.Generic;

class Third
{


    static public void Main()
    {


        LinkedList<String> my_list = new LinkedList<String>();

        // Adding elements in the LinkedList
        // Using AddLast() method
        my_list.AddLast("Zoya");
        my_list.AddLast("Shilpa");
        my_list.AddLast("Rohit");
        my_list.AddLast("Rohan");
        my_list.AddLast("Juhi");
        my_list.AddLast("Zoya");


        Console.WriteLine("Name of employees:");


        foreach (string str in my_list)
        {
            Console.WriteLine(str);
        }
        Console.WriteLine("Number of employees: {0}", my_list.Count);
        if (my_list.Contains("Shilpa") == true)
        {
            Console.WriteLine("Element Found...!!");
        }
        else
        {
            Console.WriteLine("Element Not found...!!");
        }


    }
}