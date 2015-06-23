using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Forward Difference: " + Derivatives.forward_difference(F, 10));
            Console.WriteLine("Backwards Difference: " + Derivatives.backwards_difference(F, 10));
            Console.WriteLine("Three Point: " + Derivatives.centered_three_point(F, 10));
            Console.WriteLine("Five Point:  " + Derivatives.centered_five_point(F, 10));
            Console.ReadKey();
        }

        public static Double F(Double x)
        {
            return Math.Pow(x, 12);
        }
    }
}
