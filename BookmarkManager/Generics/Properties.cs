using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Properties
    {
        public Properties()
        {
            MyPropertyString = "Pesho";
        }
        private int _MyProperty;
        public int MyProperty
        {
            get
            {
                return _MyProperty;
            }
            set
            {
                _MyProperty = value;
            }
        }

        public string MyPropertyString { get; private set; }

        //public abstract int MyPropertyInt { get; set; }
    }
}
