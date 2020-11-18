using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipHit : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name.Contains("Moon"))
        {
            GameObject.Find("Score").GetComponent<TextMesh>().text = "Score 1";

        }
        Debug.Log($"hit {other.name}");
    }

}
