using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80,25);

            //HorizontalLine HLine = new HorizontalLine(5,10,8,'#');
            //VerticalLine VLine = new VerticalLine(8,13,10,'*');
            //HLine.Drow();
            //VLine.Drow();

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine righttLine = new VerticalLine(0, 24, 78, '+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            righttLine.Drow();

            Console.ReadLine();
        }
    }
}

