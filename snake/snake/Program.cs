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
            Console.SetBufferSize(80, 25);

            //Отрисовка рамочки
            HorrizontalLine line1 = new HorrizontalLine(0, 78, 0, '+');
            HorrizontalLine line2 = new HorrizontalLine(0, 78, 24, '+');
            VerticalLine line3 = new VerticalLine(0, 24, 0, '+');
            VerticalLine line4 = new VerticalLine(0, 24, 78, '+');
            line1.Draw();
            line2.Draw();
            line3.Draw();
            line4.Draw();

            //Отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);

        }
    }
}
