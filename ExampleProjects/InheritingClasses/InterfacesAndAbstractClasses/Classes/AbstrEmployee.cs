using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAbstractClasses
{
    abstract class AbstrEmployee : ISell, IReport, IStealMoney, IStealVouchers
    {
        Random r = new Random();

        public string Position { get; set; }

        public string Name { get; set;}

        protected decimal Payment { get; set; }

        public void Sell()
        {
            if (r.Next(2) > 0)
            {
                Console.WriteLine(Position + " managed to sell something");
            }
            else
            {
                Console.WriteLine(Position + " didn't manage to sell anything");
            }
        }

        public void Report()
        {
            if (r.Next(2) > 0)
            {
                Console.WriteLine(Position + " reported success.");
            }
            else
            {
                Console.WriteLine(Position + " reported Failure and gets nothing");
            }
        }

        public AbstrEmployee()
        {
            Init();
        }

        public AbstrEmployee(string position)
            : this()
        {
            this.Position = position;
        }

        public void Steal()
        {
            Console.WriteLine("God damn it, I'm loosing stuff again.");
        }

        void IStealMoney.Steal()
        {
            Console.WriteLine("Time to take out the brander.");
        }

        void IStealVouchers.Steal()
        {
            Console.WriteLine("Guess the kids will go to bed hungry.");
        }

        public abstract void Init();
    }
}
