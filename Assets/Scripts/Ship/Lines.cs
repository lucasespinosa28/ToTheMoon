using UnityEngine;

namespace Assets.Scripts
{
    // Start is called before the first frame update
    public partial class Ship
    {
        public float[,] Positions2D { get; set; } =
        {
            {1.10f,0.50f},
            {1.00f,0.60f},
            {-0.15f,1.00f},
            {0.10f,0.55f},
            {0.10f,0.45f},
            {-0.15f,0.00f},
            {1.00f,0.40f},
            {1.10f,0.50f}
        };
        public float WidthMultiplier { get; set; } = 0.05f;
        public Color Color1 { get; set; } = Color.gray;
        public Color Color2 { get; set; } = Color.blue;
    }
}
