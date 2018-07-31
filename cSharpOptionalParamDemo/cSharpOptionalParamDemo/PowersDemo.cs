using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpOptionalParamDemo
{
    class PowersDemo
    {
        public double powers(double num1, double num2 = 1)
        {
            return Math.Pow(num1, num2);
        }
    }
}
