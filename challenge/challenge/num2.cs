using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge
{
    class num2
    {
        public static void Run2()
        {
            Console.WriteLine("Enter the string: ");
            string letter = Console.ReadLine();

            Palindrome(letter);
        }

        public static void Palindrome(string s)
        {
            int maxLenght = 0;
            string pal = "";
            List<string> asd = new List<string>();

            for(int x = 0; x< s.Length; x++)
            {
                for (int i = 2; i < s.Length-x; i++)
                {
                    string a = s.Substring(x, i);
                    string b = "";

                    for(int k = a.Length-1; k>=0; k--)
                    {
                        b += a[k];
                    }

                    if (a == b)
                    {
                        asd.Add(a);
                    }
                    
                }
            }

            foreach(var item in asd)
            {
                if(item.Length > maxLenght)
                {
                    maxLenght = item.Length;
                    pal = item;
                }
            }

            Console.WriteLine(pal);
        }

    }
}
