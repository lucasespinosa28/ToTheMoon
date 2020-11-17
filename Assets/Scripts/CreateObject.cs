using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public static class CreateObject
    {
        public static void AddRigidbody2D(GameObject @object)
        {
            var RigidbodyMeteor = @object.AddComponent<Rigidbody2D>();
            RigidbodyMeteor.gravityScale = 0;
        }
    }
}
