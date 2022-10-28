using System;
namespace array
{

    class A
    {

        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string[] arr = new string[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            string[] arr2 = new string[n];
            Console.WriteLine("String array after sort");
            Array.sort(arr);
            foreach (string element in arr)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("String array after copy");
            arr.CopyTo(arr2, 1);
            foreach (string element in arr2)
            {
                Console.Write(element + " ");
            }
            Array.Reverse(arr);
            foreach (string element in arr)
            {
                Console.Write(element + " ");
            }
            Array.Clear(arr, 1, 3);
            foreach (string element in arr)
            {
                Console.Write(element + " ");
            }
        }
    }
}
