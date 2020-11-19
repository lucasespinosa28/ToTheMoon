using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public partial class Moon
    {
        public Vector3 StartPosition { get; set; } = new Vector3(8.25f, 0.00f, 00f);
        public GameObject Add()
        {
            var MoonPosition = new GameObject("MoonPosition");
            var Moon = new GameObject("Moon");

            var DrawMoon = new Draw()
            {
                Color1 = MoonColor1,
                Color2 = MoonColor2,
                WidthMultiplier = WidthMultiplier,
            };
            DrawMoon.AddLines(Moon, Positions2D);

            var MeteorPhysics = new Physics(Moon);
            MeteorPhysics.PolygonCollider(Moon, Positions2D);

            Moon.transform.parent = MoonPosition.transform;
            MoonPosition.AddComponent<MoonMove>();
            MoonPosition.transform.position = StartPosition;
            MoonPosition.transform.localScale = new Vector3(1.5f, 1.5f, 0.0f);
            return MoonPosition;

        }
    }
}
