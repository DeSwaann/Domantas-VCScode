using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ConsoleApp3.Project.Scenes
{
    class EndScene : Scene
    {
        public EndScene(Game game) : base(game)
        {
        }
        public override void Run()
        {
            string prompt = @"You have dealt with all 5 champions of the VCS dungeon. Do you wish to proceed?";
            string[] options = { "Yes", "No"};
            Menu menu = new Menu(prompt, options);
            int selectedIndex = menu.Run();
            switch (selectedIndex)
            {
                case 0:
                    MerchantStab();
                    break;
                case 1:
                    MyGame.MyNavigationScene.Run();
                    break;


            }

        }
        private void MerchantStab()
        {
            Clear();

            if (NavigationScene.hoodedManFlag == true)
            {
                ForegroundColor = ConsoleColor.Black;
                BackgroundColor = ConsoleColor.Green;
                WriteLine("Congratulations! You have completed the VCS dungeon successfully!");
                ResetColor();
                ConsoleUtils.WaitForKeyPress();
                MyGame.MyCreditsScene.Run();
            }
            else
            {
                WriteLine("Congratulations! You have completed the VCS dungeon successfully");
                ConsoleUtils.WaitForKeyPress();
                Clear();
                WriteLine("You burst out in tears of happiness... When you see a familiar face...");
                ConsoleUtils.WaitForKeyPress();
                Clear();
                WriteLine("It's the Hooded Man");
                ConsoleUtils.WaitForKeyPress();
                Clear();
                WriteLine("He slowly approaches you");
                ConsoleUtils.WaitForKeyPress();
                Clear();
                ForegroundColor = ConsoleColor.Black;
                BackgroundColor = ConsoleColor.Red;
                WriteLine("And out of nowhere a lightning bolt kills you. Apparently, you were not the chosen one...");
                ResetColor();
                ConsoleUtils.WaitForKeyPress();
                MyGame.MyCreditsScene.Run();

            }

        }

    }
}
