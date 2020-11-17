using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    // Start is called before the first frame update
    public partial class Moon
    {
        public List<(int,float, float)> Positions2D { get; set; } = new List<(int,float, float)>
        {
            (0,0.00f,0.00f),
            (1,0.00f,1.00f),
            (2,1.00f,2.00f),
            (3,2.00f,2.00f),
            (4,3.00f,1.00f),
            (5,3.00f,0.00f),
            (6,3.00f,0.00f),
            (7,2.00f,-1.00f),
            (8,1.00f,-1.00f),
        };
        public float WidthMultiplier { get; set; } = 0.2f;
        public Color Color1 { get; set; } = Color.gray;
        public Color Color2 { get; set; } = Color.yellow;
    }
}
