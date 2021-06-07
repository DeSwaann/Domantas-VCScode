using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ConsoleApp3.Project.Scenes
{
    class MerchantScene : Scene
    {
       
        static Random r = new Random();

        public MerchantScene(Game game) : base(game)
        {

        }

        public override void Run()
        {
            string prompt = @"A cozy shack and a friedly Merchant. *" +
"You have " + MainDungeon.myHero.health + " health. *" +
"You have " + MainDungeon.myHero.potions + " potions left. *" +
"You have " + MainDungeon.myHero.coins + " coins*" +
"*" +
"*" +
"You have " + MainDungeon.myHero.weaponValue + " weapon damage and 10-20 base damage. *" +
"You have " + MainDungeon.myHero.armorValue + " armour. *";
            prompt = prompt.Replace("*", System.Environment.NewLine);
            string[] options = { "Buy +1 weapon damage | 2 coins", "Buy +1 armour | 2 coins", "Buy +1 potion | 15 coins", "Exit Merchants shack" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    AddWeaponDamage();
                    break;
                case 1:
                    AddArmour();
                    break;
                case 2:
                    BuyPotion();
                    break;
                case 3:
                    ExitMerchant();
                    break;
            }
        }

        private void AddWeaponDamage()
        {
            if(MainDungeon.myHero.coins >= 2)
            {
                MainDungeon.myHero.weaponValue++;
                Run();
            }
            else
            {
                Clear();
                WriteLine("You don't have enough coins");
                ConsoleUtils.WaitForKeyPress();
                Run();
            }

        }

        private void AddArmour()
        {
            if (MainDungeon.myHero.coins >= 2)
            {
                MainDungeon.myHero.armorValue++;
                Run();
            }
            else
            {
                Clear();
                WriteLine("You don't have enough coins");
                ConsoleUtils.WaitForKeyPress();
                Run();
            }

        }

        private void BuyPotion()
        {
            if (MainDungeon.myHero.coins >= 15)
            {
                MainDungeon.myHero.potions++;
                Run();
            }
            else
            {
                Clear();
                WriteLine("You don't have enough coins");
                ConsoleUtils.WaitForKeyPress();
                Run();
            }
            MainDungeon.myHero.potions++;
            Run();
        }

        private void ExitMerchant()
        {
            MyGame.MyNavigationScene.Run();
        }

    }
    
}
