using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

namespace Assets.Scripts
{
    public partial class Meteor
    {
        public class Side
        {
            public List<(float, float)> Bottom()
            {
                return new List<( float, float)>
                {
                    (0.00f,0.00f),
                    ( Rnd(0.25f, 0.75f), Rnd(0.00f, -0.30f)),
                    (1.00f,0.00f)
                };
            }
            public ( float, float) Right()
            {
                // return ( 1.00f, 0.50f);
                return ( Rnd(1.00f, 1.30f), Rnd(0.25f, 0.75f));
            }
            public List<( float, float)> Top()
            {
                return new List<( float, float)>
                {
                    (1.00f,1.00f),
                    ( Rnd(0.25f, 0.75f), Rnd(1.00f, 1.30f)),
                    (0.00f,1.00f)
                };
            }
            public ( float, float) Left()
            {
                return ( Rnd(0.00f, -0.30f), Rnd(0.25f, 0.75f));
            }
        }

        private static float Rnd(float min, float max) => Random.Range(min, max);
    }
}
