using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

namespace Assets.Scripts
{
    public partial class Objects
    {
        public void AddPlayer()
        {
            var Player = new GameObject("Player");
            var Ship = new GameObject
            {
                name = "Ship"
            };
            var ShipConfig = new Ship();
           
            var ShipDraw = new Draw()      
            {
                Color1 = ShipConfig.Color1,
                Color2 = ShipConfig.Color2,
                WidthMultiplier = ShipConfig.WidthMultiplier,
            };
            ShipDraw.AddLines(Ship, ShipConfig.Positions2D);

            var ShipPhysics = new Physics(Ship);
            ShipPhysics.PolygonCollider(Ship, ShipConfig.Positions2D);

            Ship.AddComponent<ShipHit>();
            Ship.transform.parent = Player.transform;
            Ship.transform.position = ShipConfig.StartPosition;

        }       
    }
}
