﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    static class Derivatives
    {
        public delegate Double F(Double x);
        public delegate Decimal D(Decimal x);

        /// <summary>
        /// Only useful for low powers of x, and even then not very useful unless x^1
        /// </summary>
        /// <param name="f">The function to compute the differential</param>
        /// <param name="x">The value at x we're computing the differeential for</param>
        /// <returns>The differential of the function at x</returns>
        public static Double forward_difference(F f, Double x)
        {
            return f(x + 1) - f(x);
        }
        public static Decimal forward_difference(D f, Decimal x)
        {
            return f(x + 1) - f(x);
        }


        /// <summary>
        /// Only useful for low powers of x, and even then not very useful unless x^1
        /// </summary>
        /// <param name="f">The function to compute the differential</param>
        /// <param name="x">The value at x we're computing the differeential for</param>
        /// <returns>The differential of the function at x</returns>
        public static Double backwards_difference(F f, Double x)
        {
            return f(x) - f(x - 1);
        }
        public static Decimal backwards_difference(D f, Decimal x)
        {
            return f(x) - f(x - 1);
        }

        /// <summary>
        /// A much more acurate differential for essentially the same computational power as the forward and backwards difference
        /// </summary>
        /// <param name="f">The function to compute the differential</param>
        /// <param name="x">The value at x we're computing the differeential for</param>
        /// <returns>The differential of the function at x</returns>
        public static Double centered_three_point(F f, Double x)
        {
            Double h = 0.000000001;
            return (f(x + h) - f(x - h)) / (2 * h);
        }
        public static Decimal centered_three_point(D f, Decimal x)
        {
            Decimal h = 0.000000001M;
            return (f(x + h) - f(x - h)) / (2 * h);
        }

        /// <summary>
        /// Apparently a more accurate calculation then the centered three point, though it seems comparable for more computation power to me.<para/>
        /// It may be due to my choice of h though.  Further studying is required.
        /// </summary>
        /// <param name="f">The function to compute the differential</param>
        /// <param name="x">The value at x we're computing the differeential for</param>
        /// <returns>The differential of the function at x</returns>
        public static Double centered_five_point(F f, Double x)
        {
            Double h = 0.000000001;
            return (f(x - 2 * h) - 8 * f(x - h) + 8 * f(x + h) - f(x + 2 * h)) / (12 * h);
        }
        public static Decimal centered_five_point(D f, Decimal x)
        {
            Decimal h = 0.000000001M;
            return (f(x - 2 * h) - 8 * f(x - h) + 8 * f(x + h) - f(x + 2 * h)) / (12 * h);
        }
        
    }
}
