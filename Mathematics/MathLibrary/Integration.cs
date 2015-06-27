using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    public static class Integration
    {

        public delegate Double F(Double x);
        public delegate Decimal D(Decimal x);

        /// <summary>
        /// The most basic integration, horribly inefficient
        /// </summary>
        /// <param name="f">The function to compute the integral for</param>
        /// <param name="a">Start value</param>
        /// <param name="b">End value</param>
        /// <returns>The intrgration from a to b if function f</returns>
        public static Double IntegrationBySummation(F f, Double a, Double b)
        {
            Double result = 0;
            Double step = 0.000001;
            for (Double i = a; i <= b; i += step)
            {
                result += f(i) * step;
            }
            return result;
        }
        public static Decimal IntegrationBySummation(D f, Decimal a, Decimal b)
        {
            Decimal result = 0;
            Decimal step = 0.000001M;
            for (Decimal i = a; i <= b; i += step)
            {
                result += f(i) * step;
            }
            return result;
        }

        /// <summary>
        /// Trapezoid Rule of Integration.  Good for integration where the power of x is 1, but quickly becomes useless beyond that
        /// </summary>
        /// <param name="f">The function to compute the integral for</param>
        /// <param name="a">Start value</param>
        /// <param name="b">End value</param>
        /// <returns>The intrgration from a to b if function f</returns>
        public static Double trapezoid_rule_power_one(F f, Double a, Double b)
        {
            return (f(a) + f(b)) * (b - a) / 2;
        }
        public static Decimal trapezoid_rule_power_one(D f, Decimal a, Decimal b)
        {
            return (f(a) + f(b)) * (b - a) / 2;
        }

        /// <summary>
        /// Using a summation using the trapezoid rule<para/>
        /// More accurate than the previos summation for less cycles.<para/>
        /// For some reason the decimal version of this method is less accurate than the double version, or the previos summation methods.
        /// </summary>
        /// <param name="f">The function to compute the integral for</param>
        /// <param name="a">Start value</param>
        /// <param name="b">End value</param>
        /// <returns>The intrgration from a to b if function f</returns>
        public static Double trapezoid_rule(F f, Double a, Double b)
        {
            Double result = 0;
            const Double step_size = 0.0001;
            for (Double i = a; i <= b; )
            {
                result += trapezoid_rule_power_one(f, i, i += step_size);
            }

            return result;
        }
        public static Decimal trapezoid_rule(D f, Decimal a, Decimal b)
        {
            Decimal result = 0;
            const Decimal step_size = 0.0001M;
            for (Decimal i = a; i <= b; )
            {
                result += trapezoid_rule_power_one(f, i, i += step_size);
            }

            return result;
        }

    }
}
