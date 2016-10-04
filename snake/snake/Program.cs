using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            /*p1.x = 1;
            p1.y = 3;
            p1.sym = '*';*/
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorrizontalLine line1 = new HorrizontalLine(5, 10, 8, '+');
            line1.Draw();

            VerticalLine line2 = new VerticalLine(9, 15, 5, '+');
            line2.Draw();

            Console.ReadLine();
        }
    }
}
