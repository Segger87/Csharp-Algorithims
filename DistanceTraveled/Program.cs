//Find the distance between 2 points

using System;

namespace Distance
{
    class Program
    {

        static void Main()
        {
            double time, acceleration, distance;

            Console.WriteLine("Enter Accelaration ");
            acceleration = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Distance traveled: ");
            distance = double.Parse(Console.ReadLine());

            time = Math.Sqrt(distance * 2 / acceleration);
            Console.WriteLine("Your car traveled for " + time + " seconds");

            Console.ReadLine();

        }
    }
}
