using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondClassImpressions
{
    class Felinae
    {
        //private string _Health;
        public string Name { get; set; }

        private string Health { get; set; }

        public DateTime BirthDate { get; set; }

        public TimeSpan Age
        {
            get
            {
                if (BirthDate != DateTime.MinValue)
                {
                    return DateTime.Now - BirthDate;
                }

                throw new Exception("Animal is too old :(");
            }
        }

        public TimeSpan LifeSpan { get; set; }

        public string Species { get; set; }

        public string FurColor { get; set; }

        private double Weight { get; set; }

        public void TakePicture()
        {
            Console.WriteLine("Picture of " + this.Name + " the " + this.Species + " has been taken.");
        }

        public void Run(int KM)
        {
            Console.WriteLine(this.Name + " has started running");

            for (int i = 1; i <= KM * 10; i++)
            {
                System.Threading.Thread.Sleep(1000);

                Console.WriteLine(this.Name + " has run " + i * 100 + " Meters");
            }

            Console.WriteLine(this.Name + " grohna");
        }

        public static void TakePicture(Felinae feline)
        {
            Console.WriteLine("Static Picture of " + feline.Name + " has been taken.");
        }
}
    }
