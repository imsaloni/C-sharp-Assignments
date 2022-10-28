using System;
namespace array
{

    class A
    {

        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] arr2 = new int[n];
            Console.WriteLine("Integer array after sort");
            Array.Sort(arr);
            foreach (int element in arr)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("Integer array after copy");
            arr.CopyTo(arr2, 1);
            foreach (int element in arr2)
            {
                Console.Write(element + " ");
            }
            Array.Reverse(arr);
            foreach (int element in arr)
            {
                Console.Write(element + " ");
            }
            Array.Clear(arr, 1, 3);
            foreach (int element in arr)
            {
                Console.Write(element + " ");
            }
        }
    }
}