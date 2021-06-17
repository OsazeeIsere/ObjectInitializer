using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=> fun with object init. syntax");
            //make a point by setting each property manually
            Point firstpoint = new Point();
            firstpoint.X = 10;
            firstpoint.Y = 10;
            firstpoint.DisplayStatus();

            //make a point via custom constructor
            Point otherPoint = new Point(20, 20);
            otherPoint.DisplayStatus();

            //make a point using object init. syntax
            Point finalPoint = new Point() { X = 30, Y = 30 };
            finalPoint.DisplayStatus();
            //calling a more interesting custom constructor
            //with init. syntax
            Point goldPoint = new Point(PointColor.Gold) { X = 90, Y = 20 };
            goldPoint.DisplayStatus();

            //CREATE and initialize a triangle
            Rectangle myRectangle = new Rectangle
            {
                TopLeft = new Point { X = 10, Y = 10 },
                BottomRight = new Point { X = 200, Y = 200 }
            };
            Console.ReadLine();


        }
    }
}
