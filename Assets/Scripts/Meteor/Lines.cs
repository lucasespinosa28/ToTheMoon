using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public partial class Meteor
    {
        public Color Color1 { get; set; } = Color.gray;
        public Color Color2 { get; set; } = Color.blue;
        public float[,] Positions2D { get; set; } = {
            { 0.00f, 0.00f },
            { 0.25f, 0.25f },
            { 0.75f, 0.25f },
            { 1.00f, 0.00f },

            { 1.25f, -0.25f},
            { 1.25f, -0.75f},
            { 1.00f, -1.00f},

            { 0.75f, -1.25f},
            { 0.25f, -1.25f},
            { 0.00f, -1.00f},

            { -0.25f, -0.75f},
            { -0.25f, -0.25f},
            { 0.00f, 0.00f}
        };
        public float WidthMultiplier { get; set; } = 0.05f;
        public int PositionCount { get; set; }      
    }
}
