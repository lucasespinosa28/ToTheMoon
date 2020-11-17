using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public  class Physics
    {
        public static void Add(GameObject @object, List<(int,float,float)> Positions2D)
        {
            var RigidbodyMeteor = @object.AddComponent<Rigidbody2D>();
       
            RigidbodyMeteor.gravityScale = 0;
            var MeteorPolygonCollider = @object.AddComponent<PolygonCollider2D>();
            var Paths = new Vector2[Positions2D.Count];
            for (int i = 0; i < Positions2D.Count; i++)
            {
                //Debug.Log($"ShipBody.SetPosition({i}, new Vector3({test.Positions2D[i, 0]}, {test.Positions2D[i, 1]}, 0.00f));");
                Paths[i] = new Vector2(Positions2D[i].Item2, Positions2D[i].Item3);
            }
            if (@object.name == "Moon")
            {
                RigidbodyMeteor.constraints = RigidbodyConstraints2D.FreezeAll;
            }         
            if(@object.name == "Ship")
            {
                MeteorPolygonCollider.isTrigger = true;
                var MeteorPolygonCollider1 = @object.AddComponent<PolygonCollider2D>();
                MeteorPolygonCollider1.SetPath(0, Paths);
                var Force = @object.AddComponent<ConstantForce2D>();
                Force.force = new Vector2(5.00f,0.00f);
            }
            MeteorPolygonCollider.SetPath(0, Paths);
        }
        
    }
}
