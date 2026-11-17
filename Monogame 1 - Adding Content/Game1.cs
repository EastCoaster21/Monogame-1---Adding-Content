using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace Monogame_1___Adding_Content
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Rectangle window;
        Texture2D dinoTexture;
        Texture2D Token;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            window = new Rectangle (0, 0, 800, 500);
            //Title of game window
            this.Window.Title = "Awesome Sauce";
            //generator = new Random();
            //dinoLocation = new Vector2(10, 10);
            //Resize Window
            _graphics.PreferredBackBufferWidth = window.Width;
            _graphics.PreferredBackBufferWidth = window.Height;
            _graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            dinoTexture = Content.Load<Texture2D>("dino");
            Token = Content.Load<Texture2D>("Token");
            
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.BlanchedAlmond);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _spriteBatch.Draw(dinoTexture, new Vector2(10, 10), Color.White *0.5f);
            //_spriteBatch.Draw(dinoTexture, dinoLocation, Color.Red);
            _spriteBatch.Draw(Token, new Vector2(-5, -15), Color.White);

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
