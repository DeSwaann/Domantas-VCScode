using ConsoleApp3.Lesson9.GUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.BigHomework4
{
    class PlayerSelectionMenu : Window
    {
        private TextBlock titleTextBlock;
        private Button[] buttonsFirstLine;
        private Button[] buttonsSecondLine;

        public int UserSelectionRow;
        public int UserSelectionColumn;

        public PlayerSelectionMenu() : base(0, 0, 120, 30, "PlayerSelectionMenu!", '%')
        {
            titleTextBlock = new TextBlock(10, 5, 100, new List<string> { "Pls select ppl", "Vardas Pavardaitis kuryba!", "Made in Vilnius Coding School!" });

            var P2 = new Button(20, 13, 18, 5, "P2");
            var P3 = new Button(50, 13, 18, 5, "P3");
            var P4 = new Button(80, 13, 18, 5, "P4");
            var P5 = new Button(20, 20, 18, 5, "P5");
            var P6 = new Button(50, 20, 18, 5, "P6");
            var P7 = new Button(80, 20, 18, 5, "P7");

            P2.IsActive = true;
            UserSelectionRow = 1;
            UserSelectionColumn = 1;

            buttonsFirstLine = new Button[3] { P2, P3, P4 };
            buttonsSecondLine = new Button[3] { P5, P6, P7 };
        }

        private Button GetButton()
        {
            if (UserSelectionRow == 1)
            {
                return buttonsFirstLine[UserSelectionColumn - 1]; // -1 because i an array index
            } 
            else
            {
                return buttonsSecondLine[UserSelectionColumn - 1];
            }
        }

        public int FinalizePlayerChoice()
        {
            var activeButton = GetButton();
            return int.Parse(activeButton.name.Substring(1, activeButton.name.Length - 1));
        }

        public void UserInputArrowLeft()
        {
            var previouslyActiveButton = GetButton();
            previouslyActiveButton.IsActive = false;
            if (UserSelectionColumn >= 2)
            {
                UserSelectionColumn -= 1;
            } else
            {
                UserSelectionColumn = 1;
            }
            var newlySelectedButton = GetButton();
            newlySelectedButton.IsActive = true;
            Render();
        }

        public void UserInputArrowRight()
        {
            var previouslyActiveButton = GetButton();
            previouslyActiveButton.IsActive = false;
            if (UserSelectionColumn <= 2)
            {
                UserSelectionColumn += 1;
            }
            else
            {
                UserSelectionColumn = 3;
            }
            var newlySelectedButton = GetButton();
            newlySelectedButton.IsActive = true;
            Render();
        }

        public void UserInputArrowUp()
        {
            if (UserSelectionRow == 2)
            {
                var previouslyActiveButton = GetButton();
                previouslyActiveButton.IsActive = false;
                UserSelectionRow = 1;
                var newlySelectedButton = GetButton();
                newlySelectedButton.IsActive = true;

                Render();
            }
        }

        public void UserInputArrowDown()
        {
            if (UserSelectionRow == 1)
            {
                var previouslyActiveButton = GetButton();
                previouslyActiveButton.IsActive = false;
                UserSelectionRow = 2;
                var newlySelectedButton = GetButton();
                newlySelectedButton.IsActive = true;

                Render();
            }
        }

        public override void Render()
        {
            base.Render();

            titleTextBlock.Render();

            foreach (var button in buttonsFirstLine)
            {
                button.Render();
            }

            foreach (var button in buttonsSecondLine)
            {
                button.Render();
            }

            Console.SetCursorPosition(0, 0);
        }
    }
}
