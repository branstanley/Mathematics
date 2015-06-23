using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    static class Derivatives
    {
        public delegate Double F(Double x);

        public static Double centered_three_point(F f, Double x)
        {
            Double h = 0.000000001;
            return (f(x+h) - f(x-h))/(2*h);
        }

        public static Double centered_five_point(F f, Double x)
        {
            Double h = 0.000000001;
            return (f(x-2*h) - 8 * f(x - h) + 8 * f(x + h) - f(x + 2 * h)) / (12 * h);
        }
        
    }
}
