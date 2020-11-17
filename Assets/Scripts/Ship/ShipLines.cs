using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    // Start is called before the first frame update
    public partial class Ship
    {
        public List<(int,float, float)> Positions2D { get; set; } = new List<(int,float, float)>
        {
            (0,1.10f,0.50f),
            (1,1.00f,0.60f),
            (2,-0.15f,1.00f),
            (3,0.10f,0.55f),
            (4,0.10f,0.45f),
            (5,-0.15f,0.00f),
            (6,1.00f,0.40f),
        };
        public float WidthMultiplier { get; set; } = 0.05f;
        public Color Color1 { get; set; } = Color.gray;
        public Color Color2 { get; set; } = Color.blue;
    }
}
