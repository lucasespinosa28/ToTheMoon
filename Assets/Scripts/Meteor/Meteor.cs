using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public partial class Meteor : CreateComponent
    {
        public void Add(int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                var MeteorPosition = new GameObject("Obstacles" + i);
                var Meteor = new GameObject("Meteor" + i);


                var MeteorColor = new Configurationlines()
                {
                    Color1 = Color.yellow,
                    Color2 = Color.yellow,
                    WidthMultiplier = 0.10f
                };
                Lines(Meteor, Positions2D(), MeteorColor);
                Physics(Meteor, Positions2D());

                MeteorPosition.AddComponent<MeteorMove>();
                Meteor.transform.parent = MeteorPosition.transform;
                MeteorPosition.transform.position = new Vector3(-4 + (i), Random.Range(-3, 4), 0);
            }
        }
    }
}
