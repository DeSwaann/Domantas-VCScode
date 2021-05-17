
using ConsoleApp3.Lesson9.Game;
using ConsoleApp3.Lesson9.GUI;
using ConsoleApp3.Lesson9.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Lesson9.Game
{
    class GameProject
    {
        static void Main()
        {
            //GameController gameController = new GameController();
            //gameController.StartGame();
            GuiController guiController = new GuiController();

            Console.CursorVisible = false;

            MenuWindow gameWindow = new MenuWindow();
            //gameWindow.Render();

             CreditWindow creditWindow = new CreditWindow();
            //creditWindow.Render();

            guiController.ShowMenu();
            
            Console.ReadKey();



        }
    }
}