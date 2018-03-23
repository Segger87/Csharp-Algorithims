//Find the distance between 2 points

using System;

namespace UnderstandingScope
{
    class Program
    {
      
        static void Main()
        {
            //variables for coordinates
            double d, x1, x2, y1, y2;
            Console.WriteLine("Enter coordinates at point A");
            x1 = Double.Parse(Console.ReadLine());
            y1 = x1;

            Console.WriteLine("Enter coordinates at point B");
            x2 = Double.Parse(Console.ReadLine());
            y2 = x2;

            //formula to work out the distance
            d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

            Console.WriteLine("The Distance between A and B is " + d);
            Console.ReadLine();
        
        }
    }
}
