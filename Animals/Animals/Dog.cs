using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Dog : Animals
    {
        public Dog(string sound) : base("bauuuuuu")
        {
            //this.Sound = "bauuuuuu";
        }

        public override string Sound
        {
            get
            {
                return "Dog say " + base.Sound + "!";
            }

        }
    }

}

