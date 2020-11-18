using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

namespace Assets.Scripts
{
    public partial class Objects
    {
        //public static void AddObstacles(int quantity)
        //{
        //    for (int i = 0; i < quantity; i++)
        //    {
        //        var MeteorPosition = new GameObject("Obstacles" + i);
        //        var Meteor = new GameObject("Meteor" + i);

        //        var MeteorConfig = new Meteor();
        //        var DrawObstacles = new Draw()      
        //        {
        //                Color1 = MeteorConfig.Color1,
        //                Color2 = MeteorConfig.Color2,
        //                WidthMultiplier = MeteorConfig.WidthMultiplier,
        //        };
        //        DrawObstacles.AddLines(Meteor, MeteorConfig.Positions2D);

        //        var MeteorPhysics = new Physics(Meteor);
        //        MeteorPhysics.PolygonCollider(Meteor,MeteorConfig.Positions2D);

        //        MeteorPosition.AddComponent<MeteorMove>();
        //        Meteor.transform.parent = MeteorPosition.transform;
        //        MeteorPosition.transform.position = new Vector3(-5+(i), Random.Range(-3, 4), 0);
        //    }            
        //}       
    }
}
