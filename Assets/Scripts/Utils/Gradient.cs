using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assets.Scripts
{
    public partial class Utils
    {
         public static Gradient Gradient(Color Color1, Color Color2, float alpha = 1.0f)
            {
                Gradient gradient = new Gradient();
                gradient.SetKeys(
                    new GradientColorKey[] { new GradientColorKey(Color1, 0.0f), new GradientColorKey(Color2, 0.5f), new GradientColorKey(Color1, 1.0f) },
                    new GradientAlphaKey[] { new GradientAlphaKey(alpha, 1f), new GradientAlphaKey(alpha, 1f) }
                );
                return gradient;
         }
    }
}
