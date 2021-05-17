using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp3.Lesson9.GUI;
using ConsoleApp3.BigHomework4.DiceFolder;


namespace ConsoleApp3.BigHomework4
{
    class DiceSelectionMenu : Window
    {
        private TextBlock titleTextBlock;
        public Dice dice;
        private Button diceButton;


        public DiceSelectionMenu() : base(0, 0, 120, 30, "Dice game menu!", '%')
        {
            dice = new Dice(3);
            titleTextBlock = new TextBlock(10, 5, 100, new List<string> { "Select the number of dice", "'+' increase the number of dice", "'-' decrease the number of dice" });

            diceButton = new Button(50, 13, 18, 5, ConvertDiceSize());

        }
        public string ConvertDiceSize()
        {
            var x = Convert.ToString(dice.GetDiceSize());
            return x;

        }
        public int ConfirmDiceSize()
        {
            return dice.GetDiceSize();
        }

        public void PlusDiceSize()
        {
            dice.IncreaseDiceSize();
            diceButton = new Button(50, 13, 18, 5, ConvertDiceSize());
            Render();
        }
        public void MinusDiceSize()
        {
            dice.DecreaseDiceSize();
            diceButton = new Button(50, 13, 18, 5, ConvertDiceSize());
            Render();
        }


        public override void Render()
        {
            base.Render();

            titleTextBlock.Render();

            diceButton.Render();

            Console.SetCursorPosition(0, 0);
        }
    }
}
