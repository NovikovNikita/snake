using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class StartGame
    {
        public StartGame()
        {
            int xOffset = 25;
            int yOffset = 8;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(xOffset, yOffset++);
            WriteText("============================", xOffset, yOffset++);
            yOffset++;
            WriteText("Нажмите enter, чтобы начать", xOffset + 1, yOffset++);
            yOffset++;
            WriteText("============================", xOffset, yOffset++);
            Console.ReadLine();
            Console.Clear();
        }
        static void WriteText(String text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }
    }
}