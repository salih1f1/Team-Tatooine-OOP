using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using OopProject.Interfaces;

namespace OopProject.Characters
{
    class AnimatedSprite : IAnimatedSprite
    {
        private Texture2D texture;
        private int row;
        private int endCol;
        private int currentFrame;
        
        public AnimatedSprite(Texture2D texture, int row, int endCol)
        {
            this.texture = texture;
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

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            int width = 64;
            int height = 64;
            int row = this.row;
            int column = currentFrame % endCol;

            Rectangle sourceRectangle = new Rectangle(width * column, height * row, width, height);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width, height);

            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
    }
}
