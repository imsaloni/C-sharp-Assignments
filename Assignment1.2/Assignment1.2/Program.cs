using System;

namespace Assignment1_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] mark = { 55, 84, 92, 41, 38 };

            int highest = 0;
            for (int i = 0; i <= 4; i++)
            {

                if (mark[i] > highest)
                    highest = mark[i];
            }
            Console.WriteLine("The Highest Mark is :");
            Console.WriteLine(highest);


        }
    }
}