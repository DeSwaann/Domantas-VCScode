using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Homework.Game1
{
    class GameScreen
    {
        private int _width;
        private int _height;

        public Hero1 hero;
        private List<Enemy1> enemies = new List<Enemy1>();

        public GameScreen(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public void SetHero(Hero1 hero)
        {
            this.hero = hero;
        }
        public void MoveHeroRight()
        {
            hero.MoveRight();
        }
        public void MoveHeroLeft()
        {
            hero.MoveLeft();
        }
        public void AddEnemy(Enemy1 enemy)
        {
            enemies.Add(enemy);
        }
        public void MoveAllEnemiesDown()
        {
            foreach(var enemy in enemies)
            {
                enemy.MoveDown();
            }
        }
        public Enemy1 GetEnemyById(int id)
        {
            foreach (var enemy in enemies)
            {
                if (enemy.GetId() == id)
                {
                    return enemy;
                }
            }
            return null;
        }
        public void Render()
        {
            hero.PrintInfo();
            foreach (var enemy in enemies)
            {
                enemy.PrintInfo();
            }
        }
    }
}
