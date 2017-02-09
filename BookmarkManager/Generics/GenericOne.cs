using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class GenericOne<T> where T : List<T>
    {
        T _MyVariable;

        public GenericOne(T d)
        {
            _MyVariable = d;
        }
        public override string ToString()
        {
            return _MyVariable.ToString();
        }

    }
    delegate TReturn Func<TReturn>();
    delegate TReturn Func<TArg, TReturn>(TArg arg);
   

}
