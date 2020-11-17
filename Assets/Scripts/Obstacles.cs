using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

namespace Assets.Scripts
{
    public class Obstacles
    {
        public void Add(int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                var Meteor = new GameObject("Obstacles" + i);
                var Body = new GameObject("Meteor" + i);

                var MeteorConfig = new Meteor();
                var test = new Draw()      
                {
                        Color1 = MeteorConfig.Color1,
                        Color2 = MeteorConfig.Color2,
                        WidthMultiplier = MeteorConfig.WidthMultiplier,
                };
                test.Add(Body, MeteorConfig.Positions2D);     
                Physics.Add(Body, MeteorConfig.Positions2D);

                Body.transform.parent = Meteor.transform;
                Body.transform.position = new Vector3(Random.Range(-6.0f,6f), Random.Range(-4.0f, 4.0f),0);
            }

        }       
    }
}
