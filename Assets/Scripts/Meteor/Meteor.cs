using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public partial class Meteor
    {
        public void Add(int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                var MeteorPosition = new GameObject("Obstacles" + i);
                var Meteor = new GameObject("Meteor" + i);

                var MeteorConfig = new Meteor();
                var DrawObstacles = new Draw()
                {
                    Color1 = Color.cyan,
                    Color2 = Color.red,
                    WidthMultiplier = MeteorConfig.WidthMultiplier,
                };
                var metoerLins = Positions2D();
                DrawObstacles.AddLines(Meteor, metoerLins);

                var MeteorPhysics = new Physics(Meteor);
                MeteorPhysics.PolygonCollider(Meteor, metoerLins);

                MeteorPosition.AddComponent<MeteorMove>();
                Meteor.transform.parent = MeteorPosition.transform;
                MeteorPosition.transform.position = new Vector3(-5 + (i), Random.Range(-3, 4), 0);
            }
        }
    }
}
