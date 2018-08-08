using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsThisATriangle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("The program checks if a triangle can be built. Type the triangle sides separated by a white space:");
            int[] TriangleSides = Array.ConvertAll(Console.ReadLine().Split(' '), temp => Convert.ToInt32(temp));
            int a = TriangleSides[0];
            int b = TriangleSides[1];
            int c = TriangleSides[2];


            bool result = IsThisATriangle(a, b, c);
            Console.WriteLine("Do the triangle with sides of length: {0}, {1}, {2} can be built: {3}", a, b, c, result);
            Console.ReadKey();
        }

        public static bool IsThisATriangle(int a, int b, int c)
        {
            bool TriangleCondition = false;
            if (a + b > c && a + c > b && b + c > a)
                TriangleCondition = true;
            return TriangleCondition;
        }
    }
}
