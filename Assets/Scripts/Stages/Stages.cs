using UnityEngine;

namespace Assets.Scripts
{
    public class Stages
    {
        public static void Level(int n)
        {
            switch (n)
            {
                case 1:
                    new Meteor().Add(1, new Vector3(Random.Range(-5.0f, 7.00f), Random.Range(-4.0f, 5.50f)));
                    break;
                case 2:
                    new Meteor().Add(1, new Vector3(Random.Range(-5.0f, -1.00f), Random.Range(-4.0f, 5.50f)));
                    new Meteor().Add(2, new Vector3(Random.Range(1.00f, 7.00f), Random.Range(-4.0f, 5.50f)));
                    break;
                case 3:
                    new Meteor().Add(1, new Vector3(Random.Range(-5.0f, -3.0f), Random.Range(-4.0f, 5.50f)));
                    new Meteor().Add(2, new Vector3(Random.Range(-2.0f, 3.0f), Random.Range(-4.0f, 5.50f)));
                    new Meteor().Add(3, new Vector3(Random.Range(4.0f, 7.0f), Random.Range(-4.0f, 5.50f)));
                    break;
                case 4:
                    new Meteor().Add(1, new Vector3(Random.Range(-5.0f, -4.0f), Random.Range(-4.0f, 5.50f)));
                    new Meteor().Add(2, new Vector3(Random.Range(-3.0f, 0.0f), Random.Range(-4.0f, 5.50f)));
                    new Meteor().Add(3, new Vector3(Random.Range(1.0f, 3.0f), Random.Range(-4.0f, 5.50f)));
                    new Meteor().Add(4, new Vector3(Random.Range(4.0f, 7.0f), Random.Range(-4.0f, 5.50f)));
                    break;
                default:
                    new Meteor().Add(1, new Vector3(Random.Range(-5.0f, -2.5f), Random.Range(-4.0f, 5.50f)));
                    new Meteor().Add(2, new Vector3(Random.Range(-3.0f, 0.5f), Random.Range(-4.0f, 5.50f)));
                    new Meteor().Add(3, new Vector3(Random.Range(1.0f, 2.5f), Random.Range(-4.0f, 5.50f)));
                    new Meteor().Add(4, new Vector3(Random.Range(3.0f, 5.5f), Random.Range(-4.0f, 5.50f)));
                    new Meteor().Add(5, new Vector3(Random.Range(6.0f, 7.0f), Random.Range(-4.0f, 5.50f)));
                    break;
              
            }
        }
    }
}
