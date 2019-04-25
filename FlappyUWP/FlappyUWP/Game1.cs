using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using Windows.Graphics.Display;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml.Controls;

namespace FlappyUWP
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        int score = 0;

        float screenWidth;
        float screenHeight;
        float pipeSpeedMultiplier;
        float ericBirdSpeedX;
        float ericBirdJumpY;
        float gravitySpeed;

        bool spaceDown;
        bool gameStarted;
        bool gameOver;

        Texture2D background;
        Texture2D startGameSplash;
        Texture2D gameOverTexture;

        SpriteClass ericBird;

        SpriteClass pipeTop;
        SpriteClass pipeBottom;
        SpriteClass pipeTop2;
        SpriteClass pipeBottom2;

        Random random;

        SpriteFont scoreFont;
        SpriteFont stateFont;


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            base.Initialize();

            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.FullScreen;

            screenHeight = ScaleToHighDPI((float)ApplicationView.GetForCurrentView().VisibleBounds.Height);
            screenWidth = ScaleToHighDPI((float)ApplicationView.GetForCurrentView().VisibleBounds.Width);

            pipeSpeedMultiplier = 0.5f;

            spaceDown = false;
            gameStarted = false;
            gameOver = false;

            random = new Random();

            ericBirdSpeedX = ScaleToHighDPI(1000f);
            ericBirdJumpY = ScaleToHighDPI(-600f);
            gravitySpeed = ScaleToHighDPI(25f);
            score = 0;

            this.IsMouseVisible = false;
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // Load textures
            startGameSplash = Content.Load<Texture2D>("start-splash");
            background = Content.Load<Texture2D>("background");
            gameOverTexture = Content.Load<Texture2D>("game-over");

            // Construct SpriteClass objects
            ericBird = new SpriteClass(GraphicsDevice, "Content/ericgif.gif", ScaleToHighDPI(0.3f));
            
            pipeTop = new SpriteClass(GraphicsDevice, "Content/pipedown.png", ScaleToHighDPI(1f));
            pipeBottom = new SpriteClass(GraphicsDevice, "Content/pipeup.png", ScaleToHighDPI(1f));

            pipeTop2 = new SpriteClass(GraphicsDevice, "Content/pipedown.png", ScaleToHighDPI(1f));
            pipeBottom2 = new SpriteClass(GraphicsDevice, "Content/pipeup.png", ScaleToHighDPI(1f));

            // Load fonts
            scoreFont = Content.Load<SpriteFont>("Score");
            stateFont = Content.Load<SpriteFont>("GameState");
        }

        protected override void Update(GameTime gameTime)
        {
            float elapsedTime = (float)gameTime.ElapsedGameTime.TotalSeconds;

            KeyboardHandler();

            if (gameOver)
            {
                ericBird.dY = 0;

                pipeTop.dX = 0;
                pipeTop.dY = 0;

                pipeBottom.dX = 0;
                pipeBottom.dY = 0;

                pipeTop2.dX = 0;
                pipeTop2.dY = 0;

                pipeBottom2.dX = 0;
                pipeBottom2.dY = 0;
            }

            ericBird.Update(elapsedTime);

            pipeTop.Update(elapsedTime);
            pipeBottom.Update(elapsedTime);

            pipeTop2.Update(elapsedTime);
            pipeBottom2.Update(elapsedTime);

            ericBird.dY += gravitySpeed;

            // Set right edge
            if (ericBird.x > screenWidth - ericBird.texture.Width / 2)
            {
                ericBird.x = screenWidth - ericBird.texture.Width / 2;
                ericBird.dX = 0;
            }

            // Set left edge
            if (ericBird.x < 0 + ericBird.texture.Width / 2)
            {
                ericBird.x = 0 + ericBird.texture.Width / 2;
                ericBird.dX = 0;
            }

            if (pipeTop.x < -50)
            {
                SpawnPipe();
                score++;
            }

            if (pipeTop2.x < -50)
            {
                SpawnPipe2();
                score++;
            }

            if (ericBird.RectangleCollision(pipeTop) || ericBird.RectangleCollision(pipeBottom) || ericBird.RectangleCollision(pipeTop2) || ericBird.RectangleCollision(pipeBottom2) || ericBird.y > screenHeight)
            {
                gameOver = true;
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.SkyBlue);

            spriteBatch.Begin();

            spriteBatch.Draw(background, new Rectangle(0, 0, (int)screenWidth, (int)screenHeight), Color.White);

            if (gameOver)
            {
                // Draw game over texture
                spriteBatch.Draw(gameOverTexture, new Vector2(screenWidth / 2 - gameOverTexture.Width / 2, screenHeight / 4 - gameOverTexture.Width / 2), Color.White);

                String pressEnter = "Press Enter to restart!";

                // Measure the size of text in the given font
                Vector2 pressEnterSize = stateFont.MeasureString(pressEnter);

                // Draw the text horizontally centered
                spriteBatch.DrawString(stateFont, pressEnter, new Vector2(screenWidth / 2 - pressEnterSize.X / 2, screenHeight - 200), Color.White);

                // If the game is over, draw the score in red
                spriteBatch.DrawString(scoreFont, score.ToString(), new Vector2(screenWidth - 100, 50), Color.Red);
            }

            else spriteBatch.DrawString(scoreFont, score.ToString(), new Vector2(screenWidth - 100, 50), Color.Black);

            if(!gameOver)
            {
                pipeTop.Draw(spriteBatch);
                pipeBottom.Draw(spriteBatch);

                pipeTop2.Draw(spriteBatch);
                pipeBottom2.Draw(spriteBatch);

                ericBird.Draw(spriteBatch);
            }

            if (!gameStarted)
            {
                // Fill the screen with black before the game starts
                spriteBatch.Draw(startGameSplash, new Rectangle(0, 0, (int)screenWidth, (int)screenHeight), Color.White);

                String title = "FLAPPY ERIC";
                String pressSpace = "Press Space to start";

                // Measure the size of text in the given font
                Vector2 titleSize = stateFont.MeasureString(title);
                Vector2 pressSpaceSize = stateFont.MeasureString(pressSpace);

                // Draw the text horizontally centered
                spriteBatch.DrawString(stateFont, title, new Vector2(screenWidth / 2 - titleSize.X / 2, screenHeight / 3), Color.ForestGreen);
                spriteBatch.DrawString(stateFont, pressSpace, new Vector2(screenWidth / 2 - pressSpaceSize.X / 2, screenHeight / 2), Color.White);
            }

            spriteBatch.End();

            base.Draw(gameTime);
        }

        public float ScaleToHighDPI(float f)
        {
            DisplayInformation d = DisplayInformation.GetForCurrentView();
            f *= (float)d.RawPixelsPerViewPixel;
            return f;
        }

        public void SpawnPipe()
        {
            pipeTop.x = screenWidth;
            pipeBottom.x = screenWidth;
            pipeTop.y = random.Next(-100, 100);
            pipeBottom.y = (int)screenHeight - random.Next(-100, 100);

            if (score % 5 == 0) pipeSpeedMultiplier += 0.2f;

            // Orient the pipe sprite towards the ericBird sprite and set velocity
            pipeTop.dX = (ericBird.x - pipeTop.x) * pipeSpeedMultiplier;
            pipeBottom.dX = (ericBird.x - pipeBottom.x) * pipeSpeedMultiplier;

            pipeTop.dY = 0;
            pipeBottom.dY = 0;
        }

        public void SpawnPipe2()
        {
            pipeTop2.x = pipeTop.x + (screenWidth / 2);
            pipeBottom2.x = pipeBottom.x + (screenWidth / 2);
            pipeTop2.y = random.Next(-100, 100);
            pipeBottom2.y = (int) screenHeight - random.Next(-100, 100);

            pipeTop2.dX = pipeTop.dX;
            pipeBottom2.dX = pipeTop.dX;

            pipeTop2.dY = 0;
            pipeBottom2.dY = 0;
        }

        public void StartGame()
        {
            // Reset ericBird position
            ericBird.x = screenWidth / 2;
            ericBird.y = screenHeight / 2;

            // Reset pipe speed and respawn them
            pipeSpeedMultiplier = 0.5f;
            SpawnPipe();
            SpawnPipe2();

            score = 0; // Reset score
        }

        void KeyboardHandler()
        {
            KeyboardState state = Keyboard.GetState();
            
            // Quit the game if Escape is pressed
            if (state.IsKeyDown(Keys.Escape)) Exit();

            // Start the game if Space is pressed.
            if (!gameStarted)
            {
                if (state.IsKeyDown(Keys.Space))
                {
                    StartGame();
                    gameStarted = true;
                    spaceDown = true;
                    gameOver = false;
                }
                return;
            }

            if (gameOver)
            {
                if (state.IsKeyDown(Keys.Enter))
                {
                    StartGame();
                    gameOver = false;
                }
            }

            // Jump if Space (or another jump key) is pressed
            if (state.IsKeyDown(Keys.Space))
            {
                if (!spaceDown) ericBird.dY = ericBirdJumpY;
            
                spaceDown = true;
            }
            else spaceDown = false;
        }
    }
}
