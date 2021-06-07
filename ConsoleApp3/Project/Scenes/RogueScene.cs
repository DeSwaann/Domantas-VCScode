using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ConsoleApp3.Project.Scenes
{
    class RogueScene : Scene
    {
        private int power = r.Next(2, 5);
        public int health = 150;
        int index = 0;
        public static bool rogueBowFlag;
        static Random r = new Random();



        public RogueScene (Game game) : base(game)
        {

        }

        public override void Run()
        {
            string prompt = @"A bow wielding Rogue that can dodge your attacks! You should be able to see this by yourself, but I'll spoil it for you:*
It has "  + health + " health. *" +
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
            int chance = r.Next(1, 5);
            Clear();
            if(chance == 1)
            {
                int damage1 = power - MainDungeon.myHero.armorValue;
                if (damage1 < 0)
                {
                    damage1 = 0;
                }
                WriteLine("The Rogue can see right through your plans. You fail to hit the Rogue and lose " + damage1 + " health.");
                MainDungeon.myHero.health -= damage1;
            }
            else
            {
                WriteLine("A sword appears in your hands. You don't seem to know how to use one, but it still does the job.");
                int damage = power - MainDungeon.myHero.armorValue;
                if (damage < 0)
                {
                    damage = 0;
                }
                int attack = r.Next(10, MainDungeon.myHero.weaponValue) + r.Next(10, 30);
                WriteLine("The Rogue loses " + attack + "health. You lose " + damage + "health.");
                MainDungeon.myHero.health -= damage;
                health -= attack;
            }

            if(MainDungeon.myHero.health <= 0)
            {
                Clear();
                ForegroundColor = ConsoleColor.Black;
                BackgroundColor = ConsoleColor.Red;
                WriteLine("You died. It appears you were not the chosen one...");
                ResetColor();
                ConsoleUtils.WaitForKeyPress();
                MyGame.MyCreditsScene.Run();
            }
            else
            {
                if( health > 0 )
                {
                    ConsoleUtils.WaitForKeyPress();
                    Run();
                }
                else
                {
                    int drop = r.Next(1, 6);
                    MainDungeon.myHero.coins += drop;
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.Green;
                    WriteLine("Rogue's dead. It's bow starts glowing, so you decide to take it.");
                    WriteLine("Rogue drops " + drop + " coins. Now you have " + MainDungeon.myHero.coins + " coins.");
                    ResetColor();
                    rogueBowFlag = true;
                    ConsoleUtils.WaitForKeyPress();
                    MyGame.MyNavigationScene.Run();
                }
            }
            
        }

        private void Defend()
        {
            Clear();
            if (index < 5)
            {
                WriteLine("You try to run away, but block the Rogues attack by accident.");
                int damage = (power / 4) - MainDungeon.myHero.armorValue;
                if (damage < 0)
                {
                    damage = 0;
                }
                int attack = (r.Next(10, MainDungeon.myHero.weaponValue) + r.Next(10, 30)) / 2;
                WriteLine("The Rogue loses " + attack + "health. You lose " + damage + "health.");
                MainDungeon.myHero.health -= damage;
                health -= attack;
                index++;

            }
            else
            {
                int damage = power - MainDungeon.myHero.armorValue;
                if (damage < 0)
                {
                    damage = 0;
                }
                WriteLine("The Rogue can see right through your plans. You fail to block and lose " + damage + " health.");
                MainDungeon.myHero.health -= damage;


            }

            if (MainDungeon.myHero.health <= 0)
            {
                Clear();
                ForegroundColor = ConsoleColor.Black;
                BackgroundColor = ConsoleColor.Red;
                WriteLine("You died. It appears you were not the chosen one...");
                ResetColor();
                ConsoleUtils.WaitForKeyPress();
                MyGame.MyCreditsScene.Run();

            }
            else
            {
                if (health > 0)
                {
                    ConsoleUtils.WaitForKeyPress();
                    Run();
                }
                else
                {
                    int drop = r.Next(1, 6);
                    MainDungeon.myHero.coins += drop;
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.Green;
                    WriteLine("Rogue's dead. It's bow starts glowing, so you decide to take it.");
                    WriteLine("Rogue drops " + drop + " coins. Now you have " + MainDungeon.myHero.coins + " coins.");
                    ResetColor();
                    rogueBowFlag = true;
                    ConsoleUtils.WaitForKeyPress();
                    MyGame.MyNavigationScene.Run();
                }
            }
        }

        private void RunAway()
        {
            Clear();
            WriteLine("We don't tolerate cowards here...");
            ConsoleUtils.WaitForKeyPress();
            Clear();
            WriteLine("So I shall execute you");
            ConsoleUtils.WaitForKeyPress();
            Clear();
            ForegroundColor = ConsoleColor.Black;
            BackgroundColor = ConsoleColor.Red;
            WriteLine("You died. It appears you were not the chosen one...");
            ResetColor();
            ConsoleUtils.WaitForKeyPress();
            MyGame.MyCreditsScene.Run();
        }
        private void Heal()
        {
            Clear();

            if (MainDungeon.myHero.potions == 0)
            {
                WriteLine("You seem to be out of potions");
                WriteLine("Your opponent seems to be a gentleman and doesn't attack you. Oh wait...");
                int damage = power - MainDungeon.myHero.armorValue;
                if (damage < 0)
                {
                    damage = 0;
                }
                MainDungeon.myHero.health -= damage;
                WriteLine("You lose " + damage + "health.");

                if (MainDungeon.myHero.health <= 0)
                {
                    Clear();
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.Red;
                    WriteLine("You died. It appears you were not the chosen one...");
                    ResetColor();
                    ConsoleUtils.WaitForKeyPress();
                    MyGame.MyCreditsScene.Run();
                }
                else
                {
                    ConsoleUtils.WaitForKeyPress();
                    Run();
                }
            }
            else
            {
                WriteLine("It looks terrible. It smells terrible. It tastes terrible. But look at the bright side, you regained 20 life");
                MainDungeon.myHero.health += MainDungeon.myHero.potionSize;
                ConsoleUtils.WaitForKeyPress();
                Run();
            }
        }

    }
}
 