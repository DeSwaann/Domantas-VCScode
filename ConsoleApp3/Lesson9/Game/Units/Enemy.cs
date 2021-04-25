using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Lesson9.Game
{
    class Enemy : Unit
    {
        private int _id;



        public Enemy(int id, int x, int y, string name) : base (x, y, name)
        {
            this._id = id;
            this._x = x;
            this._y = y;
            this._name = name;
        }

        public void MoveDown()
        {
            _y++;
        }


        public int GetId()
        {
            return _id; // ??
        }
    }
}