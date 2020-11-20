using UnityEngine;

namespace Assets.Scripts
{
    public partial class Ship : CreateComponent
    {
        public Vector3 StartPosition { get; set; } = new Vector3(-7.00f, 0.00f, 00f);

        public Ship()
        {
            var Ship = new GameObject("Ship");

            var config = new Configurationlines()
            {
                Color1 = Color.cyan,
                Color2 = Color.cyan,
                WidthMultiplier = 0.10f
            };

            Lines(Ship, Positions2D, config);
            Physics(Ship, Positions2D);

            Ship.AddComponent<ShipMove>();
            Ship.transform.position = StartPosition;
        }
        //public  GameObject Add()
        //{
          
        //    return Ship;

        //}
    }
}
