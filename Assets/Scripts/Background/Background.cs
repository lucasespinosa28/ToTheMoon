using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public partial class Background : CreateComponent
    {
        public static Vector3 StartPosition { get; set; } = new Vector3(8.25f, 0.00f, 00f);
        public Background()
        {
            var Background = new GameObject("Background");        
            for (int i = 0; i < 24; i++)
            {
                DrawLines(Vertical: i).transform.parent = Background.transform;
                DrawLines(Horizontal: i).transform.parent = Background.transform;
            }

        }
        private GameObject DrawLines(int Vertical = 0, int Horizontal = 0)
        {
            var config = new Configurationlines()
            {
                Color1 = Color.white,
                Color2 = Color.magenta,
                WidthMultiplier = 0.050f
            };
            var Positions2D = new List<(float, float)>
            {
                (-9.50f + Vertical, 7.00f - Horizontal)
            };
            if (Vertical > 0)
            {
                Positions2D.Add((-9.50f + Vertical, -7.00f));
            }
            else
            {
                Positions2D.Add((11.00f, 7.00f - Horizontal));
            }        
            var Line = new GameObject($"Line{Vertical+ Horizontal}");
            Lines(Line, Positions2D, config, false, 0.05f);
            return Line;
        }
    }
}
