using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public  class Physics
    {
        public static void Add(GameObject @object, float[,] Positions2D)
        {
            var RigidbodyMeteor = @object.AddComponent<Rigidbody2D>();
            var Force = @object.AddComponent<ConstantForce2D>();
            RigidbodyMeteor.gravityScale = 0;
            var MeteorPolygonCollider = @object.AddComponent<PolygonCollider2D>();
            var Paths = new Vector2[Positions2D.Length / 2];
            for (int i = 0; i < Positions2D.Length / 2; i++)
            {
                //Debug.Log($"ShipBody.SetPosition({i}, new Vector3({test.Positions2D[i, 0]}, {test.Positions2D[i, 1]}, 0.00f));");
                Paths[i] = new Vector2(Positions2D[i, 0], Positions2D[i, 1]);
            }
            MeteorPolygonCollider.SetPath(0, Paths);
            Force.force = new Vector2(0.00f,0.00f);
        }
        
    }
}
