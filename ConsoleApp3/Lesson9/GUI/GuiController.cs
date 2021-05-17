using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp3.Lesson9.Windows;
using ConsoleApp3.Lesson9.Game;


namespace ConsoleApp3.Lesson9.GUI
{
    class GuiController
    {
        private MenuWindow menuWindow;
        private CreditWindow creditWindow;
        private GameController gameController;

        public GuiController()
        {
            menuWindow = new MenuWindow();
            creditWindow = new CreditWindow();
            gameController = new GameController();
        }

        public void ShowMenu()
        {
            menuWindow.Render();
            //creditWindow.Render();
        }

        }
}
