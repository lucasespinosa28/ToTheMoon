﻿using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    // Start is called before the first frame update
    public partial class Moon
    {
        public List<(float, float)> Positions2D { get; set; } = new List<(float, float)>
        {
            (0.00f,0.00f),
            (0.00f,1.00f),
            (1.00f,2.00f),
            (2.00f,2.00f),
            (3.00f,1.00f),
            (3.00f,0.00f),
            (3.00f,0.00f),
            (2.00f,-1.00f),
            (1.00f,-1.00f),
        };
        public float WidthMultiplier { get; set; } = 0.1f;
        public Color MoonColor1 { get; set; } = Color.gray;
        public Color MoonColor2 { get; set; } = Color.white;
    }
}
