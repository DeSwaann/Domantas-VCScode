using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.Lesson9.Game;
using LearningApp.GameSample.Game;
using LearningApp.GameSample.Gui;

namespace ConsoleApp3.Lesson9.Game
{
    class Program
    {
        static void Main()
        {
            Hero hero = new Hero(5, 5, "Rand al'Thor");
            hero.PrintInfo();
            hero.MoveLeft();
            hero.PrintInfo();

            List<Enemy> enemies = new List<Enemy>();
            GameScreen gameScreen = new GameScreen(200, 40);
            gameScreen.SetHero(new Hero(5, 5, "Rand al'Thor"));

            int uniqueId = 0;
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                enemies.Add(new Enemy(uniqueId, rnd.Next(0, 10), rnd.Next(0, 100), "EnemyNr" + uniqueId));
                gameScreen.AddEnemy(new Enemy(uniqueId, rnd.Next(0, 10), rnd.Next(0, 100), "EnemyNr" + uniqueId));
                uniqueId++;
            }

            for (int i = 0; i < enemies.Count; i++)
            {
                enemies[i].PrintInfo();
            }
            for (int i = 0; i < enemies.Count; i++)
            {
                enemies[i].MoveDown();
            }
            for (int i = 0; i < enemies.Count; i++)
            {
                enemies[i].PrintInfo();
            }
            gameScreen.Render();

            gameScreen.MoveHeroLeft();
            gameScreen.MoveAllEnemiesDown();

            gameScreen.GetEnemyById(2).MoveDown();

            gameScreen.Render();
            GameController gameController = new GameController();
            gameController.StartGame();

            //GameController gameController = new GameController();
            //gameController.StartGame();

            Console.CursorVisible = false;

            Frame frame1 = new Frame(0, 0, 8, 5, '%');
            frame1.Render();
            Frame frame2 = new Frame(19, 5, 22, 3, '@');
            frame2.Render();
            Frame frame3 = new Frame(29, 9, 22, 10, '#');
            frame3.Render();

            TextLine text1 = new TextLine(1, 2, 6, "Hello!");
            text1.Render();
            TextLine text2 = new TextLine(20, 6, 20, "Anybody..");
            text2.Render();
            TextLine text3 = new TextLine(30, 10, 20, "There???");
            text3.Render();

            Console.ReadKey();
        }
    }
}
