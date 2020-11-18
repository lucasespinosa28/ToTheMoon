using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public partial class Meteor
    {
        //public Color Color1 { get; set; } = Color.yellow;
        //public Color Color2 { get; set; } = Color.cyan;
        public class RandomColor
        {
            private float Number { get; set; }
            public Color First()
            {
                float Index = Random.Range(0, 5);
                Number = Index;
                switch (Index)
                {
                    case 1: return Color.green;
                    case 2: return Color.yellow;
                    case 3: return Color.blue;
                    case 4: return Color.cyan;
                    case 5: return Color.magenta;
                    default: return Color.red;
                }
            }
            public Color Second()
            {
                float Index = Random.Range(0, 5);
                if (Number == Index)
                {
                    if (Index >= 5)
                    {
                        Index = Index - Random.Range(0, 5);
                    }else if (Index == 0) {
                        Index = Index + Random.Range(0, 5);
                    }
                }
                switch (Index)
                {
                    case 1: return Color.green;
                    case 2: return Color.yellow;
                    case 3: return Color.blue;
                    case 4: return Color.cyan;
                    case 5: return Color.magenta;
                    default: return Color.red;
                }
            }
        }
    }
}
