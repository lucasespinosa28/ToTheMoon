using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public partial class Meteor : CreateComponent
    {
        public void AddLegacy(int Id)
        {
            var MeteorPosition = new GameObject("Obstacles" + Id);
            var Meteor = new GameObject("Meteor" + Id);

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
            MeteorPosition.transform.position = new Vector3(-4 + (Id*1.8f), Random.Range(-3, 4), 0);
            
        }
        public void Add(int Id, Vector3 StartPosition)
        {
            var MeteorPosition = new GameObject("Obstacles" + Id);
            var Meteor = new GameObject("Meteor" + Id);

            var MeteorColor = new Configurationlines()
            {
                Color1 = Color.yellow,
                Color2 = Color.yellow,
                WidthMultiplier = 0.10f
            };
            Lines(Meteor, Positions2D(), MeteorColor);
            Physics(Meteor, Positions2D());

            MeteorPosition.AddComponent<MeteorMove>();
            Transform transform = MeteorPosition.transform;
            Meteor.transform.parent = transform;
            transform.position = StartPosition;

        }
    }
}
