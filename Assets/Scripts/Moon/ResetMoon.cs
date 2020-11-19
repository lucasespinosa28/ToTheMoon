using Assets.Scripts;
using UnityEngine;

namespace Assets.Scripts
{
    public partial class Moon
    {
        public static void Reset() => GameObject.Find("MoonPosition").transform.position = StartPosition;
    }
}
