using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assets.Scripts
{
    public class Draw
    {

        public float WidthMultiplier { get; set; }
        public Color Color1 { get; set; }
        public Color Color2 { get; set; } 
        public void Add(GameObject @object, List<(int,float,float)> Positions2D)
        {
            var ShipBody = @object.AddComponent<LineRenderer>();

            ShipBody.material = new Material(Shader.Find("Sprites/Default"));
            ShipBody.widthMultiplier = WidthMultiplier;
            ShipBody.useWorldSpace = false;
            ShipBody.positionCount = Positions2D.Count;
            ShipBody.colorGradient = Utils.Gradient(Color1, Color2);
            ShipBody.loop = true;
            //Positions2D.ForEach(Position => {
            //    ShipBody.SetPosition(Position.Item1, new Vector3(Position.Item2, Position.Item3, 0.00f));
            //});
            for (int i = 0; i < Positions2D.Count; i++)
            {
                ShipBody.SetPosition(i, new Vector3(Positions2D[i].Item2, Positions2D[i].Item3, 0.00f));
            }
        }
    }
}
