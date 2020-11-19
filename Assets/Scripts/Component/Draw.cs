using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assets.Scripts
{
    public partial class CreateComponent
    {

        public class Configurationlines 
        { 
            public float WidthMultiplier { get; set; }
            public Color Color1;
            public Color Color2;   
        }

        public void Lines(GameObject DrawObject, List<(int, float, float)> Positions2D, Configurationlines config, bool loop = true,float alpha = 1.0f)
        {
            var Lines = DrawObject.AddComponent<LineRenderer>();
            Lines.material = new Material(Shader.Find("Sprites/Default"));
            Lines.widthMultiplier = config.WidthMultiplier;
            Lines.useWorldSpace = false;
            Lines.colorGradient = Utils.Gradient(config.Color1, config.Color2, loop, alpha);
            if (!DrawObject.name.Contains("Lines"))
            {
                Lines.loop = true;

            }
            Lines.positionCount = Positions2D.Count;
            for (int i = 0; i < Positions2D.Count; i++)
            {
                Lines.SetPosition(i, new Vector3(Positions2D[i].Item2, Positions2D[i].Item3, 0.00f));
            }
            if (DrawObject.name.Contains("Meteor"))
            {
                Lines.numCornerVertices = 7;
            }
            
        }
    }
}
