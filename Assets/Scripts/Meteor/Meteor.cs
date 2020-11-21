using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public partial class Meteor : CreateComponent
    {
        public void Add(int Id, Vector3 StartPosition)
        {
            var Meteor = new GameObject("Meteor" + Id);

            var MeteorColor = new Configurationlines()
            {
                Color1 = Color.yellow,
                Color2 = Color.yellow,
                WidthMultiplier = 0.10f
            };
            Lines(Meteor, Positions2D(), MeteorColor);
            Physics(Meteor, Positions2D());

            Meteor.AddComponent<MeteorMove>();
            Meteor.transform.position = StartPosition;

        }
    }
}
