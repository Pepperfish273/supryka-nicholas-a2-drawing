// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        Color beige = new Color(190, 175, 135);
        Color grassGreen = new Color(90, 190, 85);
        Vector2 squarePos1 = new Vector2(2, 2);
        Vector2 squarePos2 = new Vector2(132, 2);
        Vector2 squarePos3 = new Vector2(264, 2);
        Vector2 squarePos4 = new Vector2(2, 132);
        Vector2 squarePos5 = new Vector2(132, 132);
        Vector2 squarePos6 = new Vector2(264, 132);
        Vector2 squarePos7 = new Vector2(2, 264);
        Vector2 squarePos8 = new Vector2(132, 264);
        Vector2 squarePos9 = new Vector2(264, 264);

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Map Discovery");
            Window.SetSize(400, 400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(grassGreen);

            Draw.LineSize = 0;
            Draw.FillColor = beige;
            //Top Left
            if ((Input.GetMouseX() > 132) || (Input.GetMouseY() > 132))
            {
                Draw.Square(squarePos1, 132);
            }
            //Top Middle
            if ((Input.GetMouseX() > 132) || (Input.GetMouseY() > 132))
            {
                Draw.Square(squarePos2, 132);
            }
            //Top Right
            if ((Input.GetMouseX() > 132) || (Input.GetMouseY() > 132))
            {
                Draw.Square(squarePos3, 132);
            }
            //Middle Left
            if ((Input.GetMouseX() > 132) || (Input.GetMouseY() > 132))
            {
                Draw.Square(squarePos4, 132);
            }
            //Middle Middle
            if ((Input.GetMouseX() > 132) || (Input.GetMouseY() > 132))
            {
                Draw.Square(squarePos5, 132);
            }
            //Middle Right
            if ((Input.GetMouseX() > 132) || (Input.GetMouseY() > 132))
            {
                Draw.Square(squarePos6, 132);
            }
            //Bottom Left
            if ((Input.GetMouseX() > 132) || (Input.GetMouseY() > 132))
            {
                Draw.Square(squarePos7, 132);
            }
            //Bottom Middle
            if ((Input.GetMouseX() > 132) || (Input.GetMouseY() > 132))
            {
                Draw.Square(squarePos8, 132);
            }
            //Bottom Right
            if ((Input.GetMouseX() < 264) || (Input.GetMouseY() < 264))
            {
                Draw.Square(squarePos9, 132);
            }

        }
    }
}
