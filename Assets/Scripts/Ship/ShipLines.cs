using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    // Start is called before the first frame update
    public partial class Ship
    {
        public List<(float, float)> Positions2D { get; set; } = new List<(float, float)>
        {
            (1.10f,0.50f),
            (1.00f,0.60f),
            (-0.15f,1.00f),
            (0.10f,0.55f),
            (0.10f,0.45f),
            (-0.15f,0.00f),
            (1.00f,0.40f),
        };
      
    }
}
