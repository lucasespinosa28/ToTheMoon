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
        public void Add(GameObject @object, float[,] Positions2D)
        {
            var ShipBody = @object.AddComponent<LineRenderer>();

            ShipBody.material = new Material(Shader.Find("Sprites/Default"));
            ShipBody.widthMultiplier = 0.05f;
            ShipBody.useWorldSpace = false;
            ShipBody.positionCount = Positions2D.Length / 2;
            ShipBody.colorGradient = Utils.Gradient(Color.gray, Color.blue);
            
            for (int i = 0; i < Positions2D.Length / 2; i++)
            {
                ShipBody.SetPosition(i, new Vector3(Positions2D[i, 0], Positions2D[i, 1], 0.00f));
            }
        }
    }
}
