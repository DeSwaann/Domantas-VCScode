using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ConsoleApp3.Project.Scenes
{
    class DragonScene : Scene
    {
        private int power = r.Next(5, 13);
        public int health = 250;
        int index = 0;
        static Random r = new Random();



        public DragonScene(Game game) : base(game)
        {

        }

        public override void Run()
        {
            string prompt = @"A flying Dragon! You should be able to see this by yourself, but I'll spoil it for you:*
It has " + health + " health. *" +
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
            if(RogueScene.rogueBowFlag == true)
            {
                Clear();
                WriteLine("A bow appears in your hands. You don't seem to know how to use one, but it still does the job.");
                int damage = power - MainDungeon.myHero.armorValue;
                if (damage < 0)
                {
                    damage = 0;
                }
                int attack = r.Next(10, MainDungeon.myHero.weaponValue) + r.Next(10, 30);
                WriteLine("The Dragon loses " + attack + "health. You lose " + damage + "health.");
                MainDungeon.myHero.health -= damage;
                health -= attack;
                if (MainDungeon.myHero.health <= 0)
                {
                    ConsoleUtils.WaitForKeyPress();
                    Clear();
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.Red;
                    WriteLine("You die. It appears you were not the chosen one...");
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
                        WriteLine("Dragon's dead.");
                        WriteLine("It drops " + drop + " coins. Now you have " + MainDungeon.myHero.coins + " coins.");
                        ResetColor();
                        NavigationScene.dragonFlag = true;
                        ConsoleUtils.WaitForKeyPress();
                        MyGame.MyNavigationScene.Run();
                    }
                }
            }
            else
            {
                Clear();
                ForegroundColor = ConsoleColor.Black;
                BackgroundColor = ConsoleColor.Red;
                WriteLine("The dragon's flying, and you don't have a proper weapon. You die.");
                ResetColor();
                ConsoleUtils.WaitForKeyPress();
                MyGame.MyCreditsScene.Run();
            }


        }

        private void Defend()
        {
            if(RogueScene.rogueBowFlag == true)
            {
                Clear();
                if (index < 5)
                {
                    WriteLine("You try to run away, but block the Dragons attack by accident.");
                    int damage = (power / 4) - MainDungeon.myHero.armorValue;
                    if (damage < 0)
                    {
                        damage = 0;
                    }
                    int attack = (r.Next(10, MainDungeon.myHero.weaponValue) + r.Next(10, 30)) / 2;
                    WriteLine("The Dragon loses " + attack + "health. You lose " + damage + "health.");
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
                    WriteLine("Dragon can see right through your plans. You fail to block and lose " + damage + " health.");
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
                        ForegroundColor = ConsoleColor.Black;
                        BackgroundColor = ConsoleColor.Green;
                        WriteLine("Dragon's dead");
                        ResetColor();
                        NavigationScene.dragonFlag = true;
                        ConsoleUtils.WaitForKeyPress();
                        MyGame.MyNavigationScene.Run();
                    }
                }
            }
            else
            {
                Clear();
                ForegroundColor = ConsoleColor.Black;
                BackgroundColor = ConsoleColor.Red;
                WriteLine("The dragon's flying, and you don't have a proper weapon. You die.");
                ResetColor();
                ConsoleUtils.WaitForKeyPress();
                MyGame.MyCreditsScene.Run();
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
