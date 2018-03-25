//write a program that calculates the hypotenuse of a right angled triangle given its two right angle sides A and B
using System;

namespace Hypotenuse
{
    class MainClass
    {
        static void Main(string[] args)
        {
            double a, b, hypotenuse;
            Console.WriteLine("Enter right angle A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter right angle B: ");
            b = Convert.ToInt32(Console.ReadLine());
            hypotenuse = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine(hypotenuse);
            Console.ReadLine();
        }
    }
}
