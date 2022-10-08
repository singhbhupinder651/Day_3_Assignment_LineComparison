using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public static class ModelALine
    {
        public static void CalculateLineLength()
        {
            //using random function to get coordinates randomly
            Random random = new Random();
            int x1 = random.Next(0, 21);
            int y1 = random.Next(0, 21);
            int x2 = random.Next(0, 21);
            int y2 = random.Next(21, 41);

            double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            Console.WriteLine("Length of the line is: " + length);
        }
    }
}
