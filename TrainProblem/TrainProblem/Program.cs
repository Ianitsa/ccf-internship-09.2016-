using System;
using System.Collections.Generic;

namespace TrainProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> allFlyDistances = new List<double>();
            List<double> times = new List<double>();
            double trainRightSpeed = 80;
            double trainLeftSpeed = 60;
            double flySpeed = 110;
            double allS = 200;

            double t;
            bool r = true;

            // Logic
            while (true)
            {
                if (r)
                {
                    t = allS / (trainRightSpeed + flySpeed);
                    r = false;
                }
                else
                {
                    t = allS / (trainLeftSpeed + flySpeed);
                    r = true;
                }
                times.Add(t);
                // 
                double leftTrainS = t * trainLeftSpeed;
                double rightTrainS = t * trainRightSpeed;

                allS = allS - leftTrainS - rightTrainS;

                double flyS = t * flySpeed;
                allFlyDistances.Add(flyS);
                
                if (allFlyDistances[0] / 100000 >= allS)
                {
                    break;
                }
            }

            // Print
            double sums = 0;
            Double.sum
            allFlyDistances
            for (int i = 0; i < allFlyDistances.Count; i++)
            {
                sums += allFlyDistances[i];
                Console.Write("{0:0.000}km ", allFlyDistances[i]);
                Console.WriteLine("{0:0.000}m", times[i] / 60);
            }
            Console.WriteLine("Sum = {0:0.000}km", sums);
        }
    }
}
