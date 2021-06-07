using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ConsoleApp3.Project.Scenes
{
    class HoodedManScene : Scene
    {
        static Random r = new Random();

        public HoodedManScene(Game game) : base(game)
        {

        }

        public override void Run()
        {
            string prompt = @"A creepy looking Hooded Man. He doesn't seem to be armed. Nor does he appear interested in you. *" +
"You have " + MainDungeon.myHero.health + " health. *" +
"You have " + MainDungeon.myHero.potions + " potions left. *";
            prompt = prompt.Replace("*", System.Environment.NewLine);
            string[] options = { "Attack", "Defend", "Run away", "Heal" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    Attack();
                    break;
                case 1:
                    Defend();
                    break;
                case 2:
                    RunAway();
                    break;
                case 3:
                    Heal();
                    break;
            }
        }

        private void Attack()
        {
            Clear();
            WriteLine("You decide to attack the unarmed Hooded Man. After lunging forward, you start feeling weird");
            ConsoleUtils.WaitForKeyPress();
            Clear();
            WriteLine("You see your body laying on the ground");
            ConsoleUtils.WaitForKeyPress();
            Clear();
            WriteLine("Apparently...");
            ConsoleUtils.WaitForKeyPress();
            Clear();
            ForegroundColor = ConsoleColor.Black;
            BackgroundColor = ConsoleColor.Red;
            WriteLine("You died. It appears you were not the chosen one...");
            ResetColor();
            ConsoleUtils.WaitForKeyPress();
            MyGame.MyCreditsScene.Run();
        }

        private void Defend()
        {
            WriteLine("You get ready to block your opponents attack, but it does nothing. The Hooded Man is not interested in you. ");
            ConsoleUtils.WaitForKeyPress();
            MyGame.MyCreditsScene.Run();
        }

        private void RunAway()
        {
            Clear();
            WriteLine("There are moments in life, when running away is the correct decision.");
            ConsoleUtils.WaitForKeyPress();
            Clear();
            ForegroundColor = ConsoleColor.Black;
            BackgroundColor = ConsoleColor.Green;
            WriteLine("You run away successfully");
            ResetColor();
            ConsoleUtils.WaitForKeyPress();
            MyGame.MyNavigationScene.Run();
        }

        private void Heal()
        {
            Clear();

            if (MainDungeon.myHero.potions == 0)
            {
                WriteLine("You seem to be out of potions");
                WriteLine("The HoodedMan has no interest in you");
                ConsoleUtils.WaitForKeyPress();
                Run();

            }
            else
            {
                WriteLine("It looks terrible. It smells terrible. It tastes terrible. But look at the bright side, you regained 20 life");
                MainDungeon.myHero.health += MainDungeon.myHero.potionSize;
                ConsoleUtils.WaitForKeyPress();
                Clear();
                WriteLine("All of a sudden, interest sparks in the Hodded Man's eyes. ");
                ConsoleUtils.WaitForKeyPress();
                Clear();
                WriteLine("He introduces to you as an Alchemist and asks for a sip of your potion. You don't mind it. ");
                ConsoleUtils.WaitForKeyPress();
                Clear();
                ForegroundColor = ConsoleColor.Black;
                BackgroundColor = ConsoleColor.Green;
                WriteLine("It looks terrible. It smells terrible. It tastes terrible. The Alchemist drops dead. ");
                ResetColor();
                NavigationScene.hoodedManFlag = true;
                ConsoleUtils.WaitForKeyPress();
                MyGame.MyNavigationScene.Run();
            }
        }

    }
}
