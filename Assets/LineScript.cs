using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

public class LineScript : MonoBehaviour
{
    // Start is called before the first frame update
    // Creates a line renderer that follows a Sin() function
    // and animates it.
    void Start()
    {
        var ship = new Player();
        var enemies = new Obstacles();
        ship.Add();
        enemies.Add(5);
    }
}
