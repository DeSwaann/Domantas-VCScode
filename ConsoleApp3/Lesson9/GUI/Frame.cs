using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.GameSample.Gui
{
    class Frame : GuiObject
    {
        private char renderChar;
        public Frame(int x, int y, int width, int height, char renderChar)
            : base(x, y, width, height)
        {
            this.renderChar = renderChar;
        }

        internal void Render()
        {
            for (int x = 0; x < Width; x++)
            {
                Console.SetCursorPosition(X + x, Y);
                Console.Write(renderChar);
                Console.SetCursorPosition(X + x, Y + Height - 1);
                Console.Write(renderChar);
            }

            for (int y = 1; y < Height - 1; y++)
            {
                Console.SetCursorPosition(X, Y + y);
                Console.Write(renderChar);
                Console.SetCursorPosition(X + Width - 1, Y + y);
                Console.Write(renderChar);

            }
        }
    }
}