using UnityEngine;

namespace Assets.Scripts
{
    public partial class Ship : CreateComponent
    {
        public Vector3 StartPosition { get; set; } = new Vector3(-7.50f, 0.00f, 00f);

        public Ship()
        {
            var Player = new GameObject("Player");
            var Ship = new GameObject("Ship");

            var config = new Configurationlines()
            {
                Color1 = Color.white,
                Color2 = Color.cyan,
                WidthMultiplier = 0.05f
            };

            Lines(Ship, Positions2D, config);
            Physics(Ship, Positions2D);

            Ship.AddComponent<ShipMove>();
            Ship.transform.parent = Player.transform;
            Ship.transform.position = StartPosition;
        }
        //public  GameObject Add()
        //{
          
        //    return Ship;

        //}
    }
}
