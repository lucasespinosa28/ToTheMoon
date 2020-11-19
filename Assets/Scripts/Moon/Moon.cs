using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public partial class Moon : CreateComponent
    {
        public static Vector3 StartPosition { get; set; } = new Vector3(8.25f, 0.00f, 00f);
        public Moon()
        {
            var MoonPosition = new GameObject("MoonPosition");
            var Moon = new GameObject("Moon");
            var config = new Configurationlines()
            {
                Color1 = Color.white,
                Color2 = Color.black,
                WidthMultiplier = 0.040f
            };

            Lines(Moon, Positions2D, config);
            Physics(Moon, Positions2D);

            Moon.transform.parent = MoonPosition.transform;
            MoonPosition.AddComponent<MoonMove>();
            MoonPosition.transform.position = StartPosition;
            MoonPosition.transform.localScale = new Vector3(1.5f, 1.5f, 0.0f);
        }
        //public GameObject Add()
        //{
            
        //    return MoonPosition;

        //}
    }
}
