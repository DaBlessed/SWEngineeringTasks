using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerTasks.Main.Logic
{
    public class NumberUtilities
    {
        public NumberUtilities() { }
        internal static int GetFibonacciValue(int n)
        {
            /*
            int fibValue;
          // var fibStore = new Dictionary<int, int>();

            if (n < 0)
            {
                return -1;
            }

            else if (n == 0 && n < 2)
            {
                return n;
            }

            else 
            {
                fibValue = GetFibonacciValue(n - 1) + GetFibonacciValue(n - 2);
              //  fibStore.Add(n, fibValue);
                return fibValue;
            }
            */

            int a, b, temp;
            a = 0; b = 1;

            for (int i = 0; i < n; i++)
            {
                temp = a;
                a = b;
                b = temp + b;
            }

            return a;

        }
    }
}
