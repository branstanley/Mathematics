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
            //Console.WriteLine("Forward Difference: " + Derivatives.forward_difference(F, 10));
            //Console.WriteLine("Forward Difference: " + Derivatives.forward_difference(D, 10));
            //Console.WriteLine("Backwards Difference: " + Derivatives.backwards_difference(F, 10));
            //Console.WriteLine("Backwards Difference: " + Derivatives.backwards_difference(D, 10));
            //Console.WriteLine("Three Point: " + Derivatives.centered_two_point(F, 10));
            //Console.WriteLine("Three Point: " + Derivatives.centered_two_point(D, 10));
            //Console.WriteLine("Five Point:  " + Derivatives.centered_four_point(F, 10));
            //Console.WriteLine("Five Point:  " + Derivatives.centered_four_point(D, 10));

            //Console.WriteLine("Second Derivative: " + Derivatives.second_derivative(F, 10));
            //Console.WriteLine("Second Derivative: " + Derivatives.second_derivative(D, 10));

            Console.WriteLine("Summation Integrate x^2 from 0 to 4: " + Integration.IntegrationBySummation(F, 0, 4));
            Console.WriteLine("Summation Integrate x^2 from 0 to 4: " + Integration.IntegrationBySummation(D, 0M, 4M));
            Console.WriteLine("Trapezoid Integrate x^2 from 0 to 4: " + Integration.trapezoid_rule_power_one(F, 0, 4));
            Console.WriteLine("Trapezoid Integrate x^2 from 0 to 4: " + Integration.trapezoid_rule_power_one(D, 0M, 4M));
            Console.WriteLine("Trapezoid Integrate x^2 from 0 to 4: " + Integration.trapezoid_rule(F, 0, 4));
            Console.WriteLine("Trapezoid Integrate x^2 from 0 to 4: " + Integration.trapezoid_rule(D, 0M, 4M));
            

            Console.ReadKey();
        }

        private static double power = 10;
        private static Decimal powerD = (Decimal)power;

        public static Double F(Double x)
        {
            return Math.Pow(x, power);
        }

        public static Decimal D(Decimal x)
        {
            Decimal output = 1;
            for (int i = 0; i < powerD; ++i)
            {
                output *= x;
            }
            return output;
        }

    }
}
