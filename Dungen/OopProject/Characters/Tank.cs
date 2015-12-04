using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace OopProject.Characters
{
    public class Tank : Character
    {
        private const int Health = 300;
        private const int Mana = 100;
        public Tank(string name, Texture2D texture2D, int x, int y)
            : base(name, Health, Mana, texture2D, x, y)
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
