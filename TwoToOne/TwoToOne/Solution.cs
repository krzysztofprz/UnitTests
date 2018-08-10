using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoToOne
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            string s1 = "xyaabbbccccdefww";
            string s2 = "xxxxyyyyabklmopq";

            string result = Longest(s1, s2);

                
            Console.WriteLine(result);
            Console.ReadKey();
        }

        public static string Longest(string s1, string s2)
        {
            string result = "";
            return result = new string(string.Concat(s1, s2).Distinct().OrderBy(c => c).ToArray());
        }
    }
}
