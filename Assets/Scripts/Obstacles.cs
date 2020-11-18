using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

namespace Assets.Scripts
{
    public partial class Objects
    {
        public void AddObstacles(int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                var MeteorPosition = new GameObject("Obstacles" + i);
                var Meteor = new GameObject("Meteor" + i);

                var MeteorConfig = new Meteor();
                var DrawObstacles = new Draw()      
                {
                        Color1 = MeteorConfig.Color1,
                        Color2 = MeteorConfig.Color2,
                        WidthMultiplier = MeteorConfig.WidthMultiplier,
                };
                DrawObstacles.AddLines(Meteor, MeteorConfig.Positions2D);

                var MeteorPhysics = new Physics(Meteor);
                MeteorPhysics.PolygonCollider(Meteor,MeteorConfig.Positions2D);


                Meteor.transform.parent = MeteorPosition.transform;
                MeteorPosition.transform.position = new Vector3(-5+(i*2), 0.00f,0);
            }

        }       
    }
}
