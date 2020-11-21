using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public partial class Meteor
    {
        public List<(float, float)> Positions2D()
        { 
            var side = new Side();
            var Positions2D  = new List<(float, float)>();

            Positions2D.AddRange(side.Bottom());
            Positions2D.Add(side.Right());
            Positions2D.AddRange(side.Top());
            Positions2D.Add(side.Left());
            return Positions2D;
        }
    }
}
