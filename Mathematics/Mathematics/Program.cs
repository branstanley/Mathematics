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
            Console.WriteLine("Three Point: " + Derivatives.centered_three_point(F, 10));
            Console.WriteLine("Five Point: " + Derivatives.centered_five_point(F, 10));
            Console.ReadKey();
        }

        public static Double F(Double x)
        {
            return x * x * x * x * x * x;
        }
    }
}
