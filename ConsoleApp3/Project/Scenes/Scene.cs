using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;


namespace ConsoleApp3.Project.Scenes
{
    class Scene
    {
        protected Game MyGame;

        public Scene(Game game)
        {
            MyGame = game;
        }
        virtual public void Run()
        {

        }
    }
}
