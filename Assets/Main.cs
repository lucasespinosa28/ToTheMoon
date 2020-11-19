using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    // Creates a line renderer that follows a Sin() function
    // and animates it.
    void Start()
    {
        new Moon();
        new Ship();
    }
}