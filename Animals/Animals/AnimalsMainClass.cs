using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class AnimalsMainClass
    {
        static void Main(string[] args)
        {
            Cat pet1 = new Cat("pet1");
            Animals pet2= new Cat("pet2");
           
            Animals pet3 = new Dog("pet3");

            Console.WriteLine(pet1.Sound);
            Console.WriteLine(pet2.Sound);
            Console.WriteLine(typeof(Cat));

            Console.WriteLine(pet3.Sound);
            Console.WriteLine(typeof(Dog));
        }
    }
}
