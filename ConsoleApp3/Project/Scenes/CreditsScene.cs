using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ConsoleApp3.Project.Scenes
{
    class CreditsScene : Scene
    {
        public CreditsScene(Game game) : base(game)
        {
        }

        public override void Run()
        {
            string prompt = @"Thanks for playing. I hope you found the VCS dungeon enjoyable :) .

The game was made by Domantas Medzevičius.
Under VCS2021 guidance.

Would you like to play again?";
            string[] options = { "Yes", "No" };
            Menu menu = new Menu(prompt, options);
            int selectedIndex = menu.Run();
            switch(selectedIndex)
            {
                case 0:
                    MainDungeon.myHero.health = 100;
                    MainDungeon.myHero.potions = 5;
                    NavigationScene.skeletonFlag = false;
                    MyGame.MySkeletonScene.health = 100;
                    RogueScene.rogueBowFlag = false;
                    MyGame.MyRogueScene.health = 150;
                    NavigationScene.berserkerFlag = false;
                    MyGame.MyBerserkerScene.health = 150;
                    NavigationScene.dragonFlag = false;
                    MyGame.MyDragonScene.health = 250;
                    NavigationScene.hoodedManFlag = false;
                    MyGame.Start();
                    return;
                case 1:
                    WriteLine("Press any key to exit...");
                    ConsoleUtils.QuitConsole();
                    break;
            }
        }
    }
}
