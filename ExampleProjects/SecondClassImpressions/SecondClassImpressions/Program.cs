using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondClassImpressions
{
    //staj > 1, ako se spravq zle - uvolnen

    class Program
    {
        static void Main(string[] args)
        {
            Felinae ChristianTheLion = new Felinae();

            //ChristianTheLion.Name = "Christian";
            //ChristianTheLion.Species = "Lion";

            //ChristianTheLion.TakePicture();

            //Felinae.TakePicture(ChristianTheLion);

            //ChristianTheLion.Run(1);

            Salesman Sasho = new Salesman("Sasho", new DateTime(2011, 6, 10), 503, "Senior janitor", 3, 0);
            
            Sasho.Info();
            Console.WriteLine(DateTime.Now);
            Console.ReadLine();
        }
    }
}
