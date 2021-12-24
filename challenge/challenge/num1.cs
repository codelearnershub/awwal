using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge
{
    class num1
    {
        public static void Run1()
        {
            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());

            int[] myAarr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the elements");
                myAarr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the target number: ");
            int target = int.Parse(Console.ReadLine());

            Position(myAarr, target);

        }
        public static void Position(int[] arr, int target)
        {
            
            List<int> positions = new List<int>();
            if(arr.Length == 0)
            {
                Console.WriteLine("-1, -1");
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    positions.Add(i);
                }
            }

            foreach(var item in positions)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
