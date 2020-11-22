using Assets.Scripts;
using UnityEngine;

namespace Assets.Scripts
{
    public partial class Ship
    {

        public static void Lunch(bool keyPressed, GameObject ship, ref bool launchable)
        {
            if (keyPressed)
            {
                ship.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;
                ship.GetComponent<ConstantForce2D>().force = new Vector2(50, 0);
                launchable = false;

            }
        }
        public static void OffScreenVertical(GameObject ship)
        {
            var ShipPosition = ship.transform;
            if (ShipPosition.position.y > 6.15)
            {
                ShipPosition.position = new Vector3(ShipPosition.position.x, -6.15f, 0.0f);
            }
            else if (ShipPosition.position.y < -6.15)
            {
                ShipPosition.position = new Vector3(ShipPosition.position.x, 6.15f, 0.0f);
            }
        }
        public static bool OffScreenHorizontal(GameObject ship)
        {
            var ShipPosition = ship.transform;
            if (ShipPosition.position.x > 13f)
            {
                return true;
            }
            else if (ShipPosition.position.x < -11f)
            {
                return true;
            }
            else
            {
                return false;
            }
 
        }
        public class Control
        {
            public static void Up(bool keyPressed, GameObject ship, ref bool launchable) 
            {
                if (launchable & keyPressed)
                {
                    if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
                    {
                        ship.transform.Translate(0, Time.deltaTime * 15, 0f);

                    }                 
                }
            }
            public static void Down(bool keyPressed, GameObject ship, ref bool launchable) 
            {
                if (launchable & keyPressed)
                {
                    if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
                    {
                        ship.transform.Translate(0, -Time.deltaTime * 15, 0f);
                    }
                }
            }
        }
    }
}