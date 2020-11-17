using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public partial class Meteor
    {
        public Color Color1 { get; set; } = Color.yellow;
        public Color Color2 { get; set; } = Color.cyan;
        public List<(int, float, float)> Positions2D { get; set; } = new List<(int, float, float)>();
        public float WidthMultiplier { get; set; } = 0.040f;
        public int PositionCount { get; set; }
        public Meteor()
        {
            
            int index = 0;
            var sides = new GenerateSide();
            Positions2D.AddRange(sides.Bottom(index));
            Positions2D.Add(sides.Right(index));
            Positions2D.AddRange(sides.Top(index));
            Positions2D.Add(sides.Left(index));
        }
    }
}
