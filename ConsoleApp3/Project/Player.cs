using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Project
{
    class Player
    {
        public bool HasFlashlight { get; set; }
        public bool HasPaint { get; set; }
        public ConsoleColor PaintColor { get; private set; }

        public Player()
        {
            HasFlashlight = false;
            HasPaint = false;
        }
        public void PickUpPaint(ConsoleColor color)
        {
            HasPaint = true;
            PaintColor = color;
        }

    }
}
