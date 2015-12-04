using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace OopProject.Characters
{
    class Warrior : Character
    {
        private const int Health = 200;
        private const int Mana = 200;
        public Warrior(string name, Texture2D text, int x, int y)
               : base(name, Mana, Health, text, x, y)
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
