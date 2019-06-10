using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine:Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, char sym)//конструктор що викликається при створенні лінії
        {
            pList = new List<Point>(); //створюємо пустий список

            for (int x = xLeft;x<xRight;x++)
            {
                Point p = new Point(x,y,sym);
                pList.Add(p);
            }

        }
    }
}
