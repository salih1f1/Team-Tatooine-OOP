using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace OopProject
{
    static class KeyboardInput
    {
        public static Vector2 HandleKey( Vector2 vector2)
        {
            KeyboardState newState = Keyboard.GetState();  // get the newest state
            float x = vector2.X;
            float y = vector2.Y;
            if (newState.IsKeyDown(Keys.Left))
            {
                x -= 3;
            }
            else if (newState.IsKeyDown(Keys.Right))
            {
                x += 3;
            }
            else if (newState.IsKeyDown(Keys.Up))
            {
                y -= 3;
            }
            else if (newState.IsKeyDown(Keys.Down))
            {
                y += 3;
            }
            return new Vector2(x, y);
        }

    }
}
