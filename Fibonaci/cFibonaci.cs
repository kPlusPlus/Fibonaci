using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fibonaci
{
    class cFibonaci
    {
        public cFibonaci()
        {

        }
        
        public int Fibonacci(int x)
        {
            if (x <= 1)
                return 1;
            return Fibonacci(x - 1) + Fibonacci(x - 2);
        }

        
    }
}
