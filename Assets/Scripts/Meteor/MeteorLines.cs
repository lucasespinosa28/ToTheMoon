using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public partial class Meteor
    {
        public float WidthMultiplier { get; set; } = 0.040f;
        public int PositionCount { get; set; }
        public List<(int, float, float)> Positions2D()
        { 
            int index = 0;
            var side = new Side();
            var Positions2D  = new List<(int, float, float)>();

            Positions2D.AddRange(side.Bottom(index));
            Positions2D.Add(side.Right(index));
            Positions2D.AddRange(side.Top(index));
            Positions2D.Add(side.Left(index));
            return Positions2D;
        }
    }
}
