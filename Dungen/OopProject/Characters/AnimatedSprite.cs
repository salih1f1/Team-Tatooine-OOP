using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using OopProject.Interfaces;

namespace OopProject.Characters
{
    class AnimatedSprite : IAnimatedSprite
    {
        private Character character;
        private int row;
        private int endCol;
        private int currentFrame;
        
        public AnimatedSprite(Character charactter, int row, int endCol)
        {
            this.character = charactter;
            this.row = row;
            this.endCol = endCol;
            this.currentFrame = 0;
        }

        public Texture2D Texture { get; set; }
        public int Row { get; set; }
        public int EndColumn { get; set; }
        public void Update()
        {
            currentFrame++;
            if (currentFrame == endCol)
                currentFrame = 0;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 vector)
        {
            int width = 64;
            int height = 64;
            int row = this.row;
            int column = currentFrame % endCol;

            Rectangle sourceRectangle = new Rectangle(width * column, height * row, width, height);
            Rectangle destinationRectangle = new Rectangle((int)vector.X, (int)vector.Y, width, height);
            spriteBatch.Draw(character.Texture2D, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}
