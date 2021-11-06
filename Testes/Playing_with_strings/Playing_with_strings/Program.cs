using System;
using System.Collections.Generic;

namespace Playing_with_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "AA-BB-CC";
            string s2 = "DD-EE";

            Console.WriteLine(s1.Split('-'));

            foreach (string a in s1.Split('-'))
            {
                Console.WriteLine(a);
            }

            Console.WriteLine();


            List<String> aa = new List<string>();

            aa.Add(s1);
            aa.Add(s2);

            foreach (string aaa in aa) {
                string[] array_a =  aaa.Split('-');
                Console.WriteLine(array_a.Length.ToString());
                if (array_a.Length == 3)
                {
                    Console.WriteLine(array_a[0]);
                    Console.WriteLine(array_a[1]);
                    Console.WriteLine(array_a[2]);
                }
                



            }
        }
    }
}
