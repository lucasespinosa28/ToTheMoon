using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public partial class Physics
    {
        public Physics(GameObject PhysicsObject)
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
        }

    }
}
