﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;
using FallParkour.Controls;
using System.ComponentModel;

namespace FallParkour.States
{
    public class MenuState : State
    {
        private List<Component> _components;

        private Texture2D menuBackGroundTexture;

        public MenuState(Game1 game, GraphicsDeviceManager graphics, ContentManager content)
            : base(game, content)
        {
        }

        public override void LoadContent()
        {
            var buttonTexture = _content.Load<Texture2D>("blok");
            var buttonFont = _content.Load<SpriteFont>("Font");
;

            _components = new List<Component>()
            {

        new Button(buttonTexture, buttonFont)
        {
          Text = "1 Player",
          Position = new Vector2(Game1.ScreenWidth / 2, 400),
          Click = new EventHandler(Button_1Player_Clicked),
          //Layer = 0.1f
        },
        new Button(buttonTexture, buttonFont)
        {
          Text = "Quit",
          Position = new Vector2(Game1.ScreenWidth / 2, 520),
          Click = new EventHandler(Button_Quit_Clicked),
          //Layer = 0.1f
        },
      };
        }

        private void Button_1Player_Clicked(object sender, EventArgs args)
        {
        }

        private void Button_Quit_Clicked(object sender, EventArgs args)
        {
            _game.Exit();
        }
        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();

            foreach (var component in _components)
                component.Draw(gameTime, spriteBatch);

            spriteBatch.End();
        }
        public override void Update(GameTime gameTime)
        {
            foreach (var component in _components)
                component.Update(gameTime);
        }
        public override void PostUpdate(GameTime gameTime)
        {

        }
    }
}
