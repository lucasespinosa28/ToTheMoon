using Assets.Scripts;
using UnityEngine;

namespace Assets.Scripts
{
    public partial class Ship
    { 
        public static void Reset(GameObject ship)
        {
            ship.transform.position = new Vector3(-7.50f, 0.00f, 00f);
            ship.GetComponent<ConstantForce2D>().force = new Vector2(0, 0);
            ship.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            ship.transform.rotation = Quaternion.identity;
            ship.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
            ship.GetComponent<LineRenderer>().colorGradient = Utils.Gradient(Color.cyan, Color.cyan);
        }
    }
}
