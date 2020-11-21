using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public partial class Moon : CreateComponent
    {
        public static Vector3 StartPosition { get; set; } = new Vector3(9.00F, 0.00f, 00f);
        public Moon()
        {
            var moon = new GameObject("Moon");
            var config = new Configurationlines()
            {
                Color1 = Color.white,
                Color2 = Color.yellow,
                WidthMultiplier = 0.15f
            };

            Lines(moon, Positions2D, config);
            Physics(moon, Positions2D);
            moon.AddComponent<MoonMove>();
            moon.transform.position = StartPosition;
        }

    }
}
