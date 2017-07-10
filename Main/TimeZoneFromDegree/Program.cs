using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeZoneFromDegree
{
    class Program
    {
        static void Main(string[] args)
        {
            DifferntTimes time = new DifferntTimes();
            time.Time();
            Console.ReadKey();
        }

    }
    public class DifferntTimes
    {
        public void Time()
        {
            Console.WriteLine("Enter The Degree You Want==");
            Double inputDegree = Convert.ToDouble(Console.ReadLine());
            Double Degree;

            for (Double hrHand = 0; hrHand < 12; hrHand++)
            {
                for (Double minHand = 0; minHand < 60; minHand++)
                {

                    Double numHourAngle = ((hrHand * 60) + minHand) * 360;
                    Double denHourAngle = (60 * 12);
                    Double numMinAngle = (360 * minHand);
                    Double denMinAngle = 60;
                    Degree = Math.Abs((numMinAngle / denMinAngle) - (numHourAngle / denHourAngle));

                    Degree = Math.Min(360 - Degree, Degree);
                    if (inputDegree < Degree)
                    {
                        if (Degree - 5.5 < inputDegree)
                            Console.WriteLine("{0}:{1}", hrHand, minHand);
                    }
                }

            }
        }
    }
}
