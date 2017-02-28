using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //The object is of type Manager, however it can be viewed as any of the interfaces or classes it inherits
            object manager = new Manager();

            (manager as ISell).Sell();
            (manager as IReport).Report();

            //There are different Implementations for each interface's Steal method and one individually for the AbstrEmployee class.
            (manager as IStealMoney).Steal();
            (manager as IStealVouchers).Steal();
            (manager as AbstrEmployee).Steal();

            //because the object is declared as an 'object' type, we need to parse it to it's original type to extract it's elements.
            (manager as Manager).ShowOff();
        }
    }
}
