using ConsoleApp3.Lesson9.GUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.BigHomework4
{
    class MainMenu : Window
    {
        private Button startButton;
        private Button creditsButton;
        private Button quitButton;
        private TextBlock titleTextBlock;
        private List<Button> buttonList;

        public MainMenu() : base(0, 0, 120, 30, "Dice game menu!", '%')
        {
            titleTextBlock = new TextBlock(10, 5, 100, new List<string> { "Super duper zaidimas", "Vardas Pavardaitis kuryba!", "Made in Vilnius Coding School!" });

            buttonList = new List<Button>();

            startButton = new Button(20, 13, 18, 5, "Start");
            startButton.IsActive = true;

            creditsButton = new Button(50, 13, 18, 5, "Credits");

            quitButton = new Button(80, 13, 18, 5, "Quit");

            buttonList.Add(startButton);
            buttonList.Add(creditsButton);
            buttonList.Add(quitButton);


        }

        public override void Render()
        {
            base.Render();

            titleTextBlock.Render();

            startButton.Render();
            creditsButton.Render();
            quitButton.Render();

            Console.SetCursorPosition(0, 0);
        }
    }
}
