using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assets.Scripts
{
    public  class Draw
    {

        public float WidthMultiplier { get; set; }
        public Color Color1;
        public Color Color2;
        public void AddLines(GameObject DrawObject, List<(int, float, float)> Positions2D)
        {
            var Lines = DrawObject.AddComponent<LineRenderer>();
            Lines.material = new Material(Shader.Find("Sprites/Default"));
            Lines.widthMultiplier = WidthMultiplier;
            Lines.useWorldSpace = false;
            Lines.colorGradient = Utils.Gradient(Color1, Color2);
            Lines.loop = true;
            Lines.positionCount = Positions2D.Count;
            for (int i = 0; i < Positions2D.Count; i++)
            {
                Lines.SetPosition(i, new Vector3(Positions2D[i].Item2, Positions2D[i].Item3, 0.00f));
            }
            
        }
    }
}
