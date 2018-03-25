//Write a program that gets a user to enter an angle in Radians and converts to degrees
using System;

namespace RadianToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double radian, degree;
            Console.WriteLine("Enter a Radian number: ");
            radian = Convert.ToInt32(Console.ReadLine());
            degree = radian * 180 / Math.PI;
            Console.WriteLine(radian + " radian is equivalanet to " + degree + " degress");
            Console.ReadLine();
        }
    }
}
