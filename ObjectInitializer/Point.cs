using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializer
{
    enum PointColor
    {
        lightBlue, BloodRed,Gold
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
       public PointColor Color { get; set; }

        //constructors
        public Point(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
            Color = PointColor.lightBlue;
        }
        public Point(PointColor ptcolor)
        {
            Color = ptcolor;
        }
        public Point()
            : this(PointColor.BloodRed) { }
        //method
        public void DisplayStatus()
        {
            Console.WriteLine("[{0}, {1}]", X, Y);
            Console.WriteLine("Point is {0}",Color);
        }
    }
    
}
