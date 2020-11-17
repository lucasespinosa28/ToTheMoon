using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 12)
        {
            Debug.Log("Lost");
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Moon")
        {
            Debug.Log("Win");
        }
    }

    //When the Primitive exits the collision, it will change Color
    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log($"Exit hit {other.name}");
    }
}
