using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World_Generator
{
    class Program
    {
        static int height = 100;
        static int width = 100;
        static char[,] map = new char[height, width];
        static void Main()
        {
            GenerateString();
            PaintMap();
            Console.ReadLine();
        }

        static void GenerateString()
        {
            Random r = new Random();
            for (int y = 0; y < height; ++y)
            {
                for (int x = 0; x < width; ++x)
                {
                    map[y, x] = Convert.ToChar(r.Next(0, 3));
                }
            }
        }

        static void PaintMap()
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if(map[y, x] == '\0')
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("~");
                    }
                    else if(map[y, x] == '\u0001')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("f");
                    }
                    else if(map[y, x] == '\u0002')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("˄");
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
