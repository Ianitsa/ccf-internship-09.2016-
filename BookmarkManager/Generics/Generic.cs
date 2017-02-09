using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Generic
    {
        private List<int> _Ages;
        private void Test()
        {
            GenericOne<int> myFirstGeneric = new GenericOne<int>(5);
            myFirstGeneric.ToString();
        }
    }
}
