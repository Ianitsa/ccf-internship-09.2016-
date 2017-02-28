using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace train
{
    class Destination
    {
        //double newDestination ;
        //double newDestinationTrain1 ;
        //double newDestinationTrain2 ;
        
        public static double NewDestination(double time1,double speedTrain1,double speedTrain2,double destination)
        {
           double newDestinationTrain1 = time1 * speedTrain1;
           double newDestinationTrain2 = time1 * speedTrain2;
           double newDestination = destination - newDestinationTrain1 - newDestinationTrain2;
            Console.WriteLine("method...");

            return newDestination;
        }

    }
}
