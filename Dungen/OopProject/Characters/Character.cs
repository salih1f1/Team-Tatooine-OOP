using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using OopProject.Interfaces;

namespace OopProject
{
    public abstract class Character : IAttack, IDamage, IDrawable
    {
        public int Health { get; set;}

        public int Mana { get; set; }

        public string Name { get; set; }

        List<Item> Inventory { get; set; }

        public Texture2D Texture2D { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Character(string name, int health, int mana, Texture2D texture2D, int x, int y)
        {
            this.X = x;
            this.Y = y;
            this.Texture2D = texture2D;
            this.Health = health;
            this.Mana = mana;
            Inventory = new List<Item>();
        }

        public abstract void Attack();

        public abstract void TakeDamage();

        public abstract void Draw();

    }
}
