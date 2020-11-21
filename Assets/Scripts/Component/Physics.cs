using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public partial class CreateComponent
    {
        public void Physics(GameObject PhysicsObject, List<(float, float)> Positions2D)
        {
            var Rigid = PhysicsObject.AddComponent<Rigidbody2D>();
            Rigid.gravityScale = 0;
          
            if (PhysicsObject.name == "Moon")
            {
                Rigid.constraints = RigidbodyConstraints2D.FreezeAll;
            }
            if (PhysicsObject.name == "Ship")
            {
                PhysicsObject.AddComponent<ConstantForce2D>();
            }
            PolygonCollider(PhysicsObject,Positions2D);
        }

        private void PolygonCollider(GameObject PhysicsObject, List<(float, float)> Positions2D)
        {
            var Collider = PhysicsObject.AddComponent<PolygonCollider2D>();
            var Paths = new Vector2[Positions2D.Count];
            for (int i = 0; i < Positions2D.Count; i++)
            {
                Paths[i] = new Vector2(Positions2D[i].Item1, Positions2D[i].Item2);
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
