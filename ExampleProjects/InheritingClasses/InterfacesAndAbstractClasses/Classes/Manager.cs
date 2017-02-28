using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAbstractClasses
{
    class Manager : AbstrEmployee
    {
        public Manager()
            : base("Manager")
        {

        }

        public override void Init()
        {
            this.Payment = 500m;
        }

        public void ShowOff()
        {
            Console.WriteLine("They pay me " + this.Payment);
        }
    }
}
