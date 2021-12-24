using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge
{
    class num3
    {
        public static void Run3()
        {
            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());

            int[] myAarr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the elements: ");
                myAarr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the target number: ");
            int target = int.Parse(Console.ReadLine());

            TargetSum(myAarr, target);

        }
        public static void TargetSum(int[] arr, int target)
        {

            List<int> positions = new List<int>();
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if(arr[i] + arr[j] == target)
                    {
                        Console.WriteLine($"{i}, {j}");
                    }
                }
            }
        }
    }
}
