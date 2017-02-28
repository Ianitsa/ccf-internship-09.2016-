using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Cat : Animals
    {
        public Cat(string sound)  
        {
             this.Sound = sound;
        }
        public override string Sound
        {
            get
            {
                return "Cat say mquuuuuuu!";
            }

            //set
            //{
            //    base.Sound = value;
            //}
        }
         

    }
}
