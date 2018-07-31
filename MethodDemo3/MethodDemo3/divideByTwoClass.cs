using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDemo3
{
    class divideByTwoClass
    {
        public void divideByTwo(int num, out int remainder)
        {
            remainder = num % 2;
            Console.WriteLine(num / 2);
        }
    }
}
