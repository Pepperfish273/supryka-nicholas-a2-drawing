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
        Color mapBeige = new Color(190, 175, 135);
        Color mapBorderBeige = new Color(175, 160, 135);
        Color grassGreen = new Color(90, 190, 85);
        Color moundGray = new Color(59, 55, 53);
        Color mountainLightGray = new Color(163, 163, 163);
        Color mountainDarkGray = new Color(135, 135, 135);
        Color mountainDarkerGray = new Color(100, 100, 100);
        Color mountainDarkererGray = new Color(59, 59, 59);
        Color riverBlue = new Color(100, 130, 230);
        Vector2 squarePos1 = new Vector2(2, 2);
        Vector2 squarePos2 = new Vector2(132, 2);
        Vector2 squarePos3 = new Vector2(264, 2);
        Vector2 squarePos4 = new Vector2(2, 132);
        Vector2 squarePos5 = new Vector2(132, 132);
        Vector2 squarePos6 = new Vector2(264, 132);
        Vector2 squarePos7 = new Vector2(2, 264);
        Vector2 squarePos8 = new Vector2(132, 264);
        Vector2 squarePos9 = new Vector2(264, 264);
        float[] moundXCoordinates = [];
        float[] riverXCoordinates = [];
        float[] moundYCoordinates = [];
        float[] riverYCoordinates = [];
        float moundRadius = 15;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Map Discovery");
            Window.SetSize(400, 400);
            //Random Mound Placement
            int mound = 12;
            moundXCoordinates = new float[mound];
            moundYCoordinates = new float[mound];
            
            for (int i = 0; i < mound; i++)
            {
                moundXCoordinates[i] = Random.Integer(20, 110);
                moundYCoordinates[i] = Random.Integer(20, 260);
            }
            //Random River Placement
            int river = 2;
            riverXCoordinates = new float[river];
            riverYCoordinates = new float[river];

            for (int i = 0; i < river; i++)
            {
                riverXCoordinates[i] = Random.Integer(160, 375);
                riverYCoordinates[i] = Random.Integer(200, 325);
            }
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(grassGreen);
            Draw.LineSize = 0;
            //Random Mound Drawing
            Draw.FillColor = moundGray;
            for (int i = 0; i < moundXCoordinates.Length; i++)
            {
                Draw.Circle(moundXCoordinates[i], moundYCoordinates[i], moundRadius);
            }
            //Random River Drawing
            Draw.LineColor = riverBlue;
            Draw.LineSize = 8;
            for (int i = 0; i < riverXCoordinates.Length; i++)
            {
                Draw.PolyLine(riverXCoordinates[i], riverYCoordinates[i], riverXCoordinates[i] - 8, riverYCoordinates[i] + 30, riverXCoordinates[i] + 2, riverYCoordinates[i] + 80, riverXCoordinates[i] - 1, riverYCoordinates[i] + 120,
                    riverXCoordinates[i] + 5, riverYCoordinates[i] + 160, riverXCoordinates[i] - 10, riverYCoordinates[i] + 225);
            }
            //Mountain Drawing
            Draw.LineSize = 0;
            Draw.FillColor = mountainDarkererGray;
            Draw.Triangle(255, 100, 365, 100, 300, 20);
            Draw.FillColor = mountainDarkerGray;
            Draw.Triangle(230, 115, 295, 115, 275, 45);
            Draw.Triangle(290, 120, 385, 120, 330, 50);
            Draw.FillColor = mountainDarkGray;
            Draw.Triangle(250, 140, 350, 140, 290, 50);
            //Map Square Drawing
            Draw.FillColor = mapBeige;
            Draw.LineSize = 2;
            Draw.LineColor = mapBorderBeige;
            //Top Left Ok
            if ((Input.GetMouseX() > 132) || (Input.GetMouseY() > 132))
            {
                Draw.Square(squarePos1, 134);
            }
            //Top Middle Ok
            if ((Input.GetMouseX() < 132) || (Input.GetMouseX() > 264) || (Input.GetMouseY() > 132))
            {
                Draw.Square(squarePos2, 134);
            }
            //Top Right Ok
            if ((Input.GetMouseX() < 264) || (Input.GetMouseY() > 132))
            {
                Draw.Square(squarePos3, 134);
            }
            //Middle Left Ok
            if ((Input.GetMouseX() > 132) || (Input.GetMouseY() < 132) || (Input.GetMouseY() > 264))
            {
                Draw.Square(squarePos4, 134);
            }
            //Middle Middle Ok
            if ((Input.GetMouseX() < 132) || (Input.GetMouseX() > 264) || (Input.GetMouseY() < 132)|| (Input.GetMouseY() > 264))
            {
                Draw.Square(squarePos5, 134);
            }
            //Middle Right Ok
            if ((Input.GetMouseX() < 264) || (Input.GetMouseY() < 132) || (Input.GetMouseY() > 264))
            {
                Draw.Square(squarePos6, 134);
            }
            //Bottom Left Ok
            if ((Input.GetMouseX() > 132) || (Input.GetMouseY() < 264))
            {
                Draw.Square(squarePos7, 134);
            }
            //Bottom Middle Ok
            if ((Input.GetMouseX() < 132) || (Input.GetMouseX() > 264) || (Input.GetMouseY() < 264))
            {
                Draw.Square(squarePos8, 134);
            }
            //Bottom Right Ok
            if ((Input.GetMouseX() < 264) || (Input.GetMouseY() < 264))
            {
                Draw.Square(squarePos9, 134);
            }

        }
    }
}
