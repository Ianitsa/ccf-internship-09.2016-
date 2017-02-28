using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> count = new List<double>();

            double speedTrain1 = 60;
            double speedTrain2 = 80;
            double speedFly = 110;
            double destination = 200;

            double newDestination = 0;
            double newDestinationFlay = 0;
            double time1;
            double newTime=0;
            double destinationFly = 0;


            time1 = destination / (speedFly +speedTrain2);
            destinationFly = speedFly * time1;
            count.Add(destinationFly);
            
          newDestination=  Destination.NewDestination(time1, speedTrain1, speedTrain2, destination);
         
            while (destinationFly*0.00001<=newDestination)
            {
                if (count.Count % 2 != 0)
                {
                    newTime = calcDistance(speedFly, newDestination, speedTrain1);
                }
                else
                {
                    newTime = calcDistance(speedFly, newDestination, speedTrain2);
                }

                newDestinationFlay = speedFly * newTime;
                count.Add(newDestinationFlay);

                newDestination = Destination.NewDestination(newTime, speedTrain1, speedTrain2, newDestination);
            }

            Console.WriteLine(count.Count);
            Console.WriteLine(count.Sum());
            foreach (var item in count)
            {
               
                Console.WriteLine(String.Format("{0:F5}", item));
         
            }
        }

        public static double calcDistance(double speedFly, double newDestination, double speedTrain)
        {
            return newDestination / (speedFly + speedTrain);
        }
    }
}
