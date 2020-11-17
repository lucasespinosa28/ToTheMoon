using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

namespace Assets.Scripts
{
    public class Goal
    {
        public void Add()
        {
            var Moon = new GameObject("MoonPosition");
            var Body = new GameObject("Moon");

            var MoonConfig = new Moon();
            var test = new Draw()      
            {
                    Color1 = MoonConfig.Color1,
                    Color2 = MoonConfig.Color2,
                    WidthMultiplier = MoonConfig.WidthMultiplier,
            };
            test.Add(Body, MoonConfig.Positions2D);     
            Physics.Add(Body, MoonConfig.Positions2D);

            Body.transform.parent = Moon.transform;
            Body.transform.position = MoonConfig.StartPosition;
            Body.transform.localScale = new Vector3(1.5f, 1.5f, 0.0f);

        }       
    }
}
