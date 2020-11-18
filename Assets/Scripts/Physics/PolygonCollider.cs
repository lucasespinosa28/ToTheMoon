using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public partial class Physics
    {
        public void PolygonCollider(GameObject PhysicsObject,List<(int, float, float)> Positions2D)
        {
            var Collider = PhysicsObject.AddComponent<PolygonCollider2D>();
            var Paths = new Vector2[Positions2D.Count];
            for (int i = 0; i < Positions2D.Count; i++)
            {
                Paths[i] = new Vector2(Positions2D[i].Item2, Positions2D[i].Item3);
            }
            if (PhysicsObject.name == "Ship")
            {
                Collider.isTrigger = true;
                var MeteorPolygonCollider1 = PhysicsObject.AddComponent<PolygonCollider2D>();
                MeteorPolygonCollider1.SetPath(0, Paths);

            }
            Collider.SetPath(0, Paths);
        }
    }
}
