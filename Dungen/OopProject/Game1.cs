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

        private Warrior warriorObj; // init field for warrior object
        private Vallian[] vallians = new Vallian[3]; //init 3 vallians

        private AnimatedSprite warriorAnimation; // Initialize field for warrior animation
        private AnimatedSprite vallianAnimation; // Initialize field for vallian animation

        private Vector2 initVectorWarrior = new Vector2(10, 100); //vector for warrior
        private Vector2 initVectorVallian = new Vector2(50, 50); //test vector for warrior

        private float timeSinceLastChange = 0f; //for counting the seconds

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            this.villian = Content.Load<Texture2D>("TextureAtlases/BadGuy");
            this.warrior = Content.Load<Texture2D>("TextureAtlases/GoodGuy");
            this.background = Content.Load<Texture2D>("TextureAtlases/amarati");

            this.warriorObj = new Warrior("Warrior", warrior, 20, 20); 
            vallians[0] = new Vallian("First", villian, 50, 50);
            vallians[1] = new Vallian("Second", villian, 150, 50);
            vallians[2] = new Vallian("Thirt", villian, 250, 50);

            warriorAnimation = new AnimatedSprite(warriorObj, (int)TextureAtlasConstants.SpellcastRow, (int)TextureAtlasConstants.SpellcastEndCol);
            vallianAnimation = new AnimatedSprite(vallians[0], (int)TextureAtlasConstants.SpellcastRow, (int)TextureAtlasConstants.SpellcastEndCol); // here is only one test vallian animation
            this.spriteBatch = new SpriteBatch(GraphicsDevice);
        }
     
        protected override void UnloadContent()
        {
            // UnloadContent will be called once per game and is the place to unload game-specific content.
        }

        // Allows the game to run logic such as updating the world, checking for collisions, gathering input, and playing audio.
        // <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            initVectorWarrior = KeyboardInput.HandleKey(initVectorWarrior); //event handler

            timeSinceLastChange += (float)gameTime.ElapsedGameTime.TotalSeconds; //second

            if (timeSinceLastChange > 1f)
            {
                initVectorVallian = Vallian.NewPos(initVectorVallian);
                timeSinceLastChange = 0f;
            }
            else
            {
                initVectorVallian = Vallian.Move(initVectorVallian);
            }
            warriorAnimation.Update();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(background, new Rectangle(0, 0, 800, 480), Color.White); //IMPORTANT! First draw background
            warriorAnimation.Draw(spriteBatch, initVectorWarrior);
            vallianAnimation.Draw(spriteBatch, initVectorVallian);
            base.Draw(gameTime);
            spriteBatch.End();
        }
    }
}
