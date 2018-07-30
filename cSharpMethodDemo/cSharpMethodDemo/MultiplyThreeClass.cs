using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpMethodDemo
{
    class MultiplyThreeClass
    {
        public int multipleByThree (int num)
        {
            return num * 3;
        }

        public decimal multipleByThree(decimal num)
        {
            return num * 3.0M;
        }

        public int multipleByThree(string num)
        {
            return Convert.ToInt32(num) * 3;
        }
    }
}
