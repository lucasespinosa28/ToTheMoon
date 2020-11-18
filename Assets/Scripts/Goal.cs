using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

namespace Assets.Scripts
{
    public partial class Objects
    {
        public static GameObject AddGoal()
        {
            var MoonPosition = new GameObject("MoonPosition");
            var Moon = new GameObject("Moon");

            var MoonConfig = new Moon();
            var DrawMoon = new Draw()
            {
                Color1 = MoonConfig.Color1,
                Color2 = MoonConfig.Color2,
                WidthMultiplier = MoonConfig.WidthMultiplier,
            };
            DrawMoon.AddLines(Moon, MoonConfig.Positions2D);

            var MeteorPhysics = new Physics(Moon);
            MeteorPhysics.PolygonCollider(Moon,MoonConfig.Positions2D);

            Moon.transform.parent = MoonPosition.transform;
            MoonPosition.transform.position = MoonConfig.StartPosition;
            MoonPosition.transform.localScale = new Vector3(1.5f, 1.5f, 0.0f);
            return MoonPosition;

        }
    }
}
