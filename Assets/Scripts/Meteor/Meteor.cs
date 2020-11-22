using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public partial class Meteor : CreateComponent
    {
        public void Add(int Id, Vector3 StartPosition,float speedUp)
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

            var speed = (0.02f* speedUp, 0.02f* speedUp);
            Meteor.AddComponent<MeteorMove>().MinMaxSpeed = speed;
            Meteor.transform.position = StartPosition;

            //int i = 63;

            //switch (i)
            //{
            //    case int n when (n >= 100):
            //        Debug.Log($"I am 100 or above: {n}");
            //        break;

            //    case int n when (n < 100 && n >= 50):
            //        Debug.Log($"I am between 99 and 50: {n}");
            //        break;

            //    case int n when (n < 50):
            //        Debug.Log($"I am less than 50: {n}");
            //        break;
            //}

        }
    }
}
