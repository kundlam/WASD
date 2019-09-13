using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace WASD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            char ch = new char();
            int x = 40, y = 12;
            //int x = Console.WindowWidth / 2;
            //int y = Console.WindowHeight / 2;
            int irány = 2;
            Console.CursorVisible = false;
            do
            {
                if (Console.KeyAvailable)
                {
                    ch = Console.ReadKey(true).KeyChar;
                    switch (ch)
                    {
                        case 'w': irány = 1;break;
                        case 'd': irány = 2;break;
                        case 's': irány = 3;break;
                        case 'a': irány = 4;break;
                    }
                }
                switch (irány)
                {
                    case 1: y--; break;
                    case 2: x++; break;
                    case 3: y++; break;
                    case 4: x--; break;
                }
                if (x < 0)
                {
                    x = 80;
                }
                else if (x == 81)
                {
                    x = 0;
                }
                if (y < 0)
                {
                    y = 24;
                }
                else if (y == 25)
                {
                    y = 0;
                }

                Console.SetCursorPosition(x, y);
                Console.Write("©");
                Thread.Sleep(30);
                Console.SetCursorPosition(x, y);
                Console.Write(" ");










            } while (ch != 27);
        }
    }
}
