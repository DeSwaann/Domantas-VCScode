using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;


namespace ConsoleApp3.Project.Scenes
{
    class TitleScene : Scene
    {
        string Title = "kappaLand";

        public TitleScene(Game game) : base(game)
        {
        }
        public override void Run()
        {
            WriteLine("The VCS Dungeon");
            string prompt = $@"{Title}
Welcome to the KappaLand. What would you like to do?
(Use the arrow keys to cycle through options and press enter to select an option.)";
            string[] options = { "Play", "About", "Exit" };
            Menu menu = new Menu(prompt, options);
            int selectedIndex = menu.Run();
            switch (selectedIndex)
            {
                case 0:
                    MainDungeon.Start();
                    MyGame.MyNavigationScene.Run();
                    break;
                case 1:
                    DisplayAboutInfo();
                    break;
                case 2:
                    ConsoleUtils.QuitConsole();
                    break;

            }

        }
        private void DisplayAboutInfo()
        {
            Clear();
            WriteLine(@"The game was made by Domantas Medzevičius.
Under VCS2021 guidance.");
            WriteLine("");
            ConsoleUtils.WaitForKeyPress();
            Run();

        }

    }
}
