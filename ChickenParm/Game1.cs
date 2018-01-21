using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;
using Microsoft.Xna.Framework.Media;

namespace ChickenParm
{
	/// <summary>
	/// This is the main type for your game.
	/// </summary>
	public class Game1 : Game
	{
        /// <summary>
        /// </summary>
        /// 
        Texture2D textureBall;

		GraphicsDeviceManager graphics;
		SpriteBatch spriteBatch;

		public Game1()
		{

			graphics = new GraphicsDeviceManager (this);
            Content.RootDirectory = "Content";
		}

		protected override void Initialize ()
		{
			base.Initialize ();
		}

		protected override void LoadContent ()
		{
			// Create a new SpriteBatch, which can be used to draw textures.
			spriteBatch = new SpriteBatch (GraphicsDevice);

            // TODO: use this.Content to load your game content here
            textureBall = Content.Load<Texture2D>("Recipe-Chicken_Parmesan");
		}

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

		protected override void Draw (GameTime gameTime)
        {
            graphics.GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            spriteBatch.Draw(textureBall, new Vector2(0, 0), Color.White);
            spriteBatch.End();

			base.Draw (gameTime);
		}
	}
}
