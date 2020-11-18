using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

namespace Assets.Scripts
{
    public partial class Meteor
    {
        //public (int,float,float) StartPoint(int index) => (++index, Rnd(-0.10f, 0.10f), Rnd(-0.10f, 0.10f));
        public class Side
        {
            public List<(int, float, float)> Bottom(int index)
            {
                return new List<(int, float, float)>
                {
                    (++index, Rnd(-0.10f, 0.10f), Rnd(-0.10f, 0.10f)),
                    (++index, Rnd(0.30f, 0.60f), Rnd(-0.15f, 0.15f)),
                    (++index, Rnd(0.90f, 1.10f), Rnd(-0.10f, 0.10f)),
                };
            }
            public (int, float, float) Right(int index) 
            {
                return (++index, Rnd(0.90f, 1.10f), Rnd(0.30f, 0.60f));
            }
            public List<(int, float, float)> Top(int index)
            {
                return new List<(int, float, float)>
                {
                    (++index, Rnd(0.90f, 1.10f), Rnd(0.90f, 1.10f) ),
                    (++index, Rnd(0.80f, 0.20f), Rnd(0.60f, 1.30f)),
                    (++index, Rnd(-0.10f, 0.10f), Rnd(0.90f, 1.10f) ),
                };
            }
            public (int, float, float) Left(int index)
            {
                return (++index, Rnd(-0.10f, 0.10f), Rnd(0.30f, 0.60f));
            }
        }

        private static float  Rnd(float min, float max) => Random.Range(min, max);
    }
}
