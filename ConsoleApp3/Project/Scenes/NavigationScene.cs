using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ConsoleApp3.Project.Scenes
{
    class NavigationScene : Scene
    {
        public static bool skeletonFlag;
        public static bool berserkerFlag;
        public static bool dragonFlag;
        public static bool hoodedManFlag;

        public NavigationScene(Game game) : base(game)
        {

        }

        public override void Run()
        {
            string prompt = "It's not something I usually do... But I really like your name, " + MainDungeon.myHero.name + ". *So I'll let you choose your next opponent. *";
            prompt = prompt.Replace("*", System.Environment.NewLine);
            string[] options = { "Skeleton", "Rogue", "Berserker", "Dragon", "Hooded Man", "Merchant", "Cave Exit"};
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch(selectedIndex)
            {
                case 0:
                    if(skeletonFlag == false)
                    {
                        MyGame.MySkeletonScene.Run();
                    }
                    else
                    {
                        Clear();
                        WriteLine("The Skeleton is nowhere to be found");
                        ConsoleUtils.WaitForKeyPress();
                        Run();
                    }
                    return;
                case 1:
                    if (RogueScene.rogueBowFlag == false)
                    {
                        MyGame.MyRogueScene.Run();
                    }
                    else
                    {
                        Clear();
                        WriteLine("The Rogue is nowhere to be found");
                        ConsoleUtils.WaitForKeyPress();
                        Run();
                    }
                    break;
                case 2:
                    if (berserkerFlag == false)
                    {
                        MyGame.MyBerserkerScene.Run();
                    }
                    else
                    {
                        Clear();
                        WriteLine("Even death couldn't make him look calm");
                        ConsoleUtils.WaitForKeyPress();
                        Run();
                    }
                    break;
                case 3:
                    if (dragonFlag == false)
                    {
                        MyGame.MyDragonScene.Run();                    }
                    else
                    {
                        Clear();
                        WriteLine("You enter the Dragons cave. All you see is his mountain of gold. You can't seem to find a use for it");
                        ConsoleUtils.WaitForKeyPress();
                        Run();
                    }
                    break;
                case 4:
                    if (hoodedManFlag == false)
                    {
                        MyGame.MyHoodedManScene.Run();
                    }
                    else
                    {
                        Clear();
                        WriteLine("The idea alone crossing his path makes you turn around");
                        ConsoleUtils.WaitForKeyPress();
                        Run();
                    }
                    break;
                case 5:
                    MyGame.MyMerchantScene.Run();
                    break;
                case 6:
                    if(skeletonFlag == true && RogueScene.rogueBowFlag == true && berserkerFlag == true && dragonFlag == true)
                    {
                        MyGame.MyEndScene.Run();
                    }
                    else
                    {
                        Clear();
                        WriteLine("You are not ready yet");
                        ConsoleUtils.WaitForKeyPress();
                        Run();

                    }
                    break;

            }    
        }
    }
}
