using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public static class CompareTwoLines
    {
        public static void TwoLinesComparison()
        {

            //using random function to get coordinates randomly
            Random random = new Random();

            //line one coordinates
            int x1 = random.Next(0, 21);
            int y1 = random.Next(0, 21);
            int x2 = random.Next(0, 21);
            int y2 = random.Next(21, 41);   //parameters changed for y2 coordinate to avoid zero-
                                            //-effective length for line one possible in some cases

            //line two coordinates
            int p1 = random.Next(0, 21);
            int q1 = random.Next(0, 21);
            int p2 = random.Next(0, 21);
            int q2 = random.Next(21, 41);   //parameters changed for q2 coordinate to avoid zero-
                                            //-effective length for line two possible in some cases

            double lineOneLength = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            double lineTwoLength = Math.Sqrt(Math.Pow((p2 - p1), 2) + Math.Pow((q2 - q1), 2));

            Console.WriteLine("Length of Line One: " + lineOneLength);
            Console.WriteLine("Length of Line Two: " + lineTwoLength);

            //using CompareTo method to check which line is longer in length
            int result = lineOneLength.CompareTo(lineTwoLength);

            if (result > 0)
            {
                Console.WriteLine("Line one({0}) is greater than line two({1})", lineOneLength, lineTwoLength);
            }
            else if (result == 0)
            {
                Console.WriteLine("Line one is equal to line two");
            }
            else
            {
                Console.WriteLine("Line one({0}) is lesser than line two({1})", lineOneLength, lineTwoLength);
            }


        }
    }
}
