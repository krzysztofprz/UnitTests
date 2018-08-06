using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCounting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number to bit converter. Type your number: ");
            string input = Console.ReadLine();
            
            int x = Convert.ToInt32(input);
            int result = CountBits(x);
            Console.WriteLine("Number 1 occurs: {0} times", result);
            Console.ReadKey();
        }

        public static int CountBits(int n)
        {
            int res = n;
            string binary = Convert.ToString(res, 2);
                                   
            Console.WriteLine("Binary version of {0}: {1}", res, binary);

            int counted = binary.Count(t => t == '1');
            return counted;
        }
    }
}
