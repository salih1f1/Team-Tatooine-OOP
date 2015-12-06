using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using OopProject.Characters;
using OopProject.Enumeration;

namespace OopProject
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private Texture2D bot;
        private Texture2D villian; // Initialize field for villian image
        private Texture2D warrior; // Initialize field for warrior image
        private Texture2D background; // Initialize field for warrior image
        private AnimatedSprite villianAnimation; // Initialize field for villian animation

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            this.villian = Content.Load<Texture2D>("TextureAtlases/BadGuy");
            this.background = Content.Load<Texture2D>("TextureAtlases/amarati");
            villianAnimation = new AnimatedSprite(villian, (int)TextureAtlasConstants.WalkRightRow, (int)TextureAtlasConstants.WalkEndCol);
            this.spriteBatch = new SpriteBatch(GraphicsDevice);
        }
     
        protected override void UnloadContent()
        {
            // UnloadContent will be called once per game and is the place to unload
            // game-specific content.
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            
            villianAnimation.Update();
            base.Update(gameTime);
        }

        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(background, new Rectangle(0, 0, 800, 480), Color.White); //IMPORTANT! First draw background
            villianAnimation.Draw(spriteBatch, new Vector2(0, 0));

            base.Draw(gameTime);
        }
    }
}
