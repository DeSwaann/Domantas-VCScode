using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Homework.Game1
{
    class GameProject
    {
        static void Main()
        {
            Hero1 hero = new Hero1(5,5, "Petras");
            hero.PrintInfo();
            hero.MoveRight();
            hero.MoveLeft();

            GameScreen gameScreen = new GameScreen(200, 40);
            gameScreen.SetHero(new Hero1(5, 5, "Petras"));

            List<Enemy1> enemies = new List<Enemy1>();
            Random r = new Random();
            int uniqueID = 0;
            for (int i = 0; i < 10; i++)
            {
                enemies.Add(new Enemy1(uniqueID, r.Next(0, 10), r.Next(0, 100), "EnemyNr" + uniqueID));
                uniqueID++;
            }

            for(int i = 0; i < enemies.Count; i++)
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

            gameScreen.GetEnemyById(0).MoveDown();

            gameScreen.Render();
        }
    }
}