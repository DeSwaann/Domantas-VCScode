using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.BigHomework4
{
    class GameController
    {
        private MainMenu _menuWindow;
        public PlayerSelectionMenu PlayerSelectionMenu;
        public DiceSelectionMenu DiceSelectionMenu;
        public GameOverMenu GameOverMenu;

        public GameController()
        {
            _menuWindow = new MainMenu();
            PlayerSelectionMenu = new PlayerSelectionMenu();
            DiceSelectionMenu = new DiceSelectionMenu();
            GameOverMenu = new GameOverMenu();
        }

        public void ShowMenu()
        {
            _menuWindow.Render();
        }

        public void ShowPlayerSelectionMenu()
        {
            PlayerSelectionMenu.Render();
        }
        public void ShowDiceSelectionMenu()
        {
            DiceSelectionMenu.Render();
        }
        public void ShowGameOverMenu()
        {
            GameOverMenu.Render();
        }
    }
}
