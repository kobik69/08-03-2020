using System;

namespace _08_03_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[11];
            arr[0] = 101;
            arr[1] = 202;
            arr[2] = 303;
            arr[3] = 404;
            arr[10] = 999;

            foreach (var item in arr)
            {
                Console.WriteLine("you have this value :" +item);
                Console.WriteLine(arr[10]);
            }
            Console.ReadKey();       
        }
    }
}
