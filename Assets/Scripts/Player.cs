using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

namespace Assets.Scripts
{
    public partial class Objects
    {
        public static GameObject AddPlayer()
        {
            var Player = new GameObject("Player");
            var Ship = new GameObject("Ship");         
            var ShipConfig = new Ship();
           
            var ShipDraw = new Draw()      
            {
                Color1 = ShipConfig.ShipColor1,
                Color2 = ShipConfig.ShipColor2,
                WidthMultiplier = ShipConfig.WidthMultiplier,
            };
            ShipDraw.AddLines(Ship, ShipConfig.Positions2D);

            var ShipPhysics = new Physics(Ship);
            ShipPhysics.PolygonCollider(Ship, ShipConfig.Positions2D);

            Ship.AddComponent<ShipMove>();
            Ship.transform.parent = Player.transform;
            Ship.transform.position = ShipConfig.StartPosition;
            return Ship;

        }       
    }
}
