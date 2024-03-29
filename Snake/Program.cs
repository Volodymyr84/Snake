﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80,25);
                    
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine righttLine = new VerticalLine(0, 24, 78, '+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            righttLine.Drow();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p,4,Direction.RIGHT);
            snake.Drow();

            while (true)
            {
                if (Console.KeyAvailable)
                { 
                ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }

                Thread.Sleep(100);
                snake.Move();

            }

            //Console.ReadLine();
        }
    }
}

