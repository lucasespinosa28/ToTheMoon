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
                //var Positions2D = new List<(float, float)>();
                //var Line = new GameObject($"LinesVertical{i}");
                //Positions2D.Add((-9.50f + i, 7.00f));
                //Positions2D.Add((-9.50f + i, -7.00f));
                //Lines(Line, Positions2D, config, false, 0.05f);
                //Line.transform.parent = Background.transform;

                //Positions2D = new List<(float, float)>();
                //Line = new GameObject($"LinesHorizontal{i}");
                //Positions2D.Add((-9.50f, 7.00f - i));
                //Positions2D.Add((11.00f, 7.00f - i));
                //Lines(Line, Positions2D, config, false, 0.05f);
                //Line.transform.parent = Background.transform;
                //Line.transform.parent = Background.transform;

                DrawLines(Vertical: i).transform.parent = Background.transform;
                DrawLines(Horizontal: i).transform.parent = Background.transform;
            }

        }
        private GameObject DrawLines(int Vertical = 0, int Horizontal = 0)
        {
            var config = new Configurationlines()
            {
                Color1 = Color.black,
                Color2 = Color.white,
                WidthMultiplier = 0.10f
            };

            //var Line = new GameObject($"LinesVertical{i}");
            //Positions2D.Add((-9.50f + i, 7.00f));
            //Positions2D.Add((-9.50f + i, -7.00f));

            //Line = new GameObject($"LinesHorizontal{i}");
            //Positions2D.Add((-9.50f, 7.00f - i));
            //Positions2D.Add((11.00f, 7.00f - i));

            var Positions2D = new List<(float, float)>();
            Positions2D.Add((-9.50f + Vertical, 7.00f - Horizontal));
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
            //var Line = new GameObject($"LinesHorizontal{i}");
            //Lines(Line, Positions2D, config, false, 0.05f);


            //Line.transform.parent = Background.transform;
            //    var BackgroudLine = new GameObject($"Lines{Vertical + Horizontal}");
            //    var Positions2D = new List<(int, float, float)>
            //    {
            //        (Vertical, -9.50f + Vertical, 7.00f - Horizontal),
            //        (Vertical, -9.50f + Vertical,  7.00f - Horizontal)
            //    };
            //    Lines(BackgroudLine, Positions2D, new Configurationlines()
            //    {
            //        Color1 = Color.black,
            //        Color2 = Color.white,
            //        WidthMultiplier = 0.10f
            //    }, false, 1f);
            //    BackgroudLine.transform.parent = Background.transform;
        }
    }
}
