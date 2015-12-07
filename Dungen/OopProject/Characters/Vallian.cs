using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace OopProject.Characters
{
    class Vallian : Character
    {
        private const int Health = 200;
        private const int Mana = 300;
        public Vallian(string name, int health, int mana, Texture2D texture2D, int x, int y) : base(name, health, mana, texture2D, x, y)
        {
        }

        public override void Attack()
        {
            throw new NotImplementedException();
        }

        public override void TakeDamage()
        {
            throw new NotImplementedException();
        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
