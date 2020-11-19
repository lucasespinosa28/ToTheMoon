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
            var config = new Configurationlines()
            {
                Color1 = Color.black,
                Color2 = Color.white,
                WidthMultiplier = 0.10f
            };
            for (int i = 0; i < 24; i++)
            {
                var Positions2D = new List<(int, float, float)>();
                var Line = new GameObject($"LinesVertical{i}");
                Positions2D.Add((i, -9.50f + i, 7.00f));
                Positions2D.Add((i, -9.50f + i, -7.00f));
                Lines(Line, Positions2D, config,false,0.05f);
                Line.transform.parent = Background.transform;

            }
            for (int i = 0; i < 24; i++)
            {
                var Positions2D = new List<(int, float, float)>();
                var Line = new GameObject($"LinesHorizontal{i}");
                Positions2D.Add((i, -9.50f, 7.00f - i));
                Positions2D.Add((i, 11.00f, 7.00f - i));
                Lines(Line, Positions2D, config, false, 0.05f);
                Line.transform.parent = Background.transform;

            }

        }
        //public void AddLines(int loop)
        //{

        //}
        //public GameObject Add()
        //{
            
        //    return MoonPosition;

        //}
    }
}
