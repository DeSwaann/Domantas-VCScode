using ConsoleApp3.BigHomework4.DiceFolder;
using ConsoleApp3.Lesson9.Game;
using ConsoleApp3.Lesson9.GUI;
using ConsoleApp3.Lesson9.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.BigHomework4
{
    class MainDiceGame
    {
        static void Main()
        {
            int playerCount = 0;
            int diceCount = 0;

            GameController gameController = new GameController();
            gameController.ShowMenu();


            ConsoleKey key;
            do
            {
                while (!Console.KeyAvailable)
                {
                    
                }

                
                key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.P)
                {
                    gameController.ShowPlayerSelectionMenu();
                }
                else if (key == ConsoleKey.Q)
                {
                    Console.WriteLine("SHOULD QUIT THE APP");
                }
                else if (key == ConsoleKey.Enter)
                {
                    
                    if (playerCount == 0) 
                    {
                        playerCount = gameController.PlayerSelectionMenu.FinalizePlayerChoice();
                        Console.WriteLine("PLAYER COUNT " + playerCount);

                        gameController.ShowDiceSelectionMenu();
                    }
                    else 
                    {
                        diceCount = gameController.DiceSelectionMenu.ConfirmDiceSize();
                        gameController.ShowGameOverMenu(/*playerCount, diceCount*/);
                    }
                }
                else if (key == ConsoleKey.LeftArrow)
                {
                    gameController.PlayerSelectionMenu.UserInputArrowLeft();
                }
                else if (key == ConsoleKey.RightArrow)
                {
                    gameController.PlayerSelectionMenu.UserInputArrowRight();
                }
                else if (key == ConsoleKey.UpArrow)
                {
                    gameController.PlayerSelectionMenu.UserInputArrowUp();
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    gameController.PlayerSelectionMenu.UserInputArrowDown();
                }
                else if (key == ConsoleKey.Add)
                {
                    gameController.DiceSelectionMenu.PlusDiceSize();
                }
                else if (key == ConsoleKey.Subtract)
                {
                    gameController.DiceSelectionMenu.MinusDiceSize();
                }

            } while (key != ConsoleKey.Escape);








            /*Player player1 = new Player("Player1");
            Player player2 = new Player("Player2");
            Player player3 = new Player("Player3");
            Player player4 = new Player("Player4");
            Player player5 = new Player("Player5");
            Player player6 = new Player("Player6");
            Player player7 = new Player("Player7");

            player1.PlayerRollTheDice();
            player2.PlayerRollTheDice();
            player3.PlayerRollTheDice();
            player4.PlayerRollTheDice();
            player5.PlayerRollTheDice();
            player6.PlayerRollTheDice();
            player7.PlayerRollTheDice();*/

        }
    }
}
