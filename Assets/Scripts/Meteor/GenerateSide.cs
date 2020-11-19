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
            public List<(int, float, float)> Bottom(int index)
            {
                return new List<(int, float, float)>
                {
                    (++index,0.00f,0.00f),
                    (++index, Rnd(0.25f, 0.75f), Rnd(0.00f, -0.30f)),
                    (++index,1.00f,0.00f)
                };
            }
            public (int, float, float) Right(int index)
            {
                // return (++index, 1.00f, 0.50f);
                return (++index, Rnd(1.00f, 1.30f), Rnd(0.25f, 0.75f));
            }
            public List<(int, float, float)> Top(int index)
            {
                return new List<(int, float, float)>
                {
                    (++index,1.00f,1.00f),
                    (++index, Rnd(0.25f, 0.75f), Rnd(1.00f, 1.30f)),
                    (++index,0.00f,1.00f)
                };
            }
            public (int, float, float) Left(int index)
            {
                return (++index, Rnd(0.00f, -0.30f), Rnd(0.25f, 0.75f));
            }
        }

        private static float Rnd(float min, float max) => Random.Range(min, max);
    }
}
