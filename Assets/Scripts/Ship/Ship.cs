using UnityEngine;

namespace Assets.Scripts
{
    public partial class Ship
    {
        public Vector3 StartPosition { get; set; } = new Vector3(-7.50f, 0.00f, 00f);

        public  GameObject Add()
        {
            var Player = new GameObject("Player");
            var Ship = new GameObject("Ship");

            var ShipDraw = new Draw()
            {
                Color1 = ShipColor1,
                Color2 = ShipColor2,
                WidthMultiplier = WidthMultiplier,
            };
            ShipDraw.AddLines(Ship, Positions2D);

            var ShipPhysics = new Physics(Ship);
            ShipPhysics.PolygonCollider(Ship, Positions2D);

            Ship.AddComponent<ShipMove>();
            Ship.transform.parent = Player.transform;
            Ship.transform.position = StartPosition;
            return Ship;

        }
    }
}
