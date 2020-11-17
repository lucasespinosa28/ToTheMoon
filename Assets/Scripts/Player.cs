using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

namespace Assets.Scripts
{
    public class Player
    {
        public void Add()
        {
            var Player = new GameObject("Player");
            var Body = new GameObject("Ship");

            var ShipConfig = new Ship();
            var test = new Draw()      
            {
                    Color1 = ShipConfig.Color1,
                    Color2 = ShipConfig.Color2,
                    WidthMultiplier = ShipConfig.WidthMultiplier,
            };
            test.Add(Body, ShipConfig.Positions2D);     
            Physics.Add(Body, ShipConfig.Positions2D);
            Physics.Add(Player, ShipConfig.Positions2D);
            Body.AddComponent<ShipHit>();
            Body.transform.parent = Player.transform;
            Body.transform.position = ShipConfig.StartPosition;

        }       
    }
}
