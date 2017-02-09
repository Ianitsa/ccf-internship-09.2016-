using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class GenericMethod
    {
        private void Test()
        {
            int a = 3;
            int b = 4;
            Swap<int>(ref a, ref b);
        }
        public static void Swap<T>(ref T left, ref T right)
        {
            T temp = right;
            right = left;
            left = temp;
        }
    }
}
