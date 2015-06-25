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
            Console.WriteLine("Forward Difference: " + Derivatives.forward_difference(D, 10));
            Console.WriteLine("Backwards Difference: " + Derivatives.backwards_difference(F, 10));
            Console.WriteLine("Backwards Difference: " + Derivatives.backwards_difference(D, 10));
            Console.WriteLine("Three Point: " + Derivatives.centered_two_point(F, 10));
            Console.WriteLine("Three Point: " + Derivatives.centered_two_point(D, 10));
            Console.WriteLine("Five Point:  " + Derivatives.centered_four_point(F, 10));
            Console.WriteLine("Five Point:  " + Derivatives.centered_four_point(D, 10));

            Console.WriteLine("Second Derivative: " + Derivatives.second_derivative(F, 10));
            Console.WriteLine("Second Derivative: " + Derivatives.second_derivative(D, 10));

            Console.ReadKey();
        }

        public static Double F(Double x)
        {
            return Math.Pow(x, 12);
        }

        public static Decimal D(Decimal x)
        {
            Decimal output = x;
            for (int i = 0; i < 11; ++i)
            {
                output *= x;
            }
            return output;
        }

    }
}
