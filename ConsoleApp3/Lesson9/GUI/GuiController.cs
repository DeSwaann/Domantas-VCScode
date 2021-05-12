using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp3.Lesson9.Windows;


namespace ConsoleApp3.Lesson9.GUI
{
    class GuiController
    {
        private MenuWindow menuWindow;
        private CreditWindow creditWindow;
        public GuiController()
        {
            menuWindow = new MenuWindow();
            creditWindow = new CreditWindow();
        }

        public void ShowMenu()
        {
            menuWindow.Render();
            creditWindow.Render();
        }

    }
}
