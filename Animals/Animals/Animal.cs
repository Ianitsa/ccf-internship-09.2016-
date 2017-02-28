using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Animals
{
  public  abstract class  Animals
    {
        
        public virtual string Sound { get; set; }
       // public string Animal { get; set; }

        public Animals(string sound)
        {
            this.Sound= sound;
        }

        public Animals()
        {
                
        }
        }
    }
