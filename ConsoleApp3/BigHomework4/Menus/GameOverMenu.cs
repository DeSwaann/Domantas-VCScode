using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp3.Lesson9.GUI;
using ConsoleApp3.BigHomework4.DiceFolder;
using System.Linq;

namespace ConsoleApp3.BigHomework4
{
    class GameOverMenu : Window
    {
        private TextBlock playerScoreBlock;
        private List<int> scoreList = new List<int>();
        private int a;
        private int b;
        private int c;
        private int d;
        private int e;
        private int f;
        private int g;
        private bool isUnique;




        public GameOverMenu() : base(0, 0, 120, 30, "Dice game menu!", '%')
        {
            playerScoreBlock = new TextBlock(10, 10, 100, new List<string> { "Select the number of dice", "'+' increase the number of dice", "'-' decrease the number of dice", "a", "b " });
        }

        public void PlayersRollTheDice(int playerCount)
        {
            switch (playerCount)
            {
                case 2:
                    Player player1 = new Player();
                    Player player2 = new Player();

                    do {
                        a = player1.PlayerRollTheDice();
                        b = player2.PlayerRollTheDice();
                        Console.WriteLine(a);
                        Console.WriteLine(b);
                        scoreList.Add(a);
                        scoreList.Add(b);
                        //scoreList.Select(x => x.b).Distinct().Count();
                        isUnique = scoreList.Distinct().Count() == scoreList.Count();
                        if(isUnique == false)
                        {
                            Console.WriteLine("Lygiosios, reikalingas permetimas");
                            Console.ReadKey();
                        }

                    } while (isUnique == false);




                    break;

            }    
        }
 
        public override void Render()
        {
            base.Render();

            playerScoreBlock.Render();

            Console.SetCursorPosition(0, 0);
        }
    }
}
