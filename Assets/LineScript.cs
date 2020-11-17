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
        var Ship = new Player();
        var Enemies = new Obstacles();
        var Moon = new Goal();
        Ship.Add();
        Enemies.Add(6);
        Moon.Add();
    }
}
