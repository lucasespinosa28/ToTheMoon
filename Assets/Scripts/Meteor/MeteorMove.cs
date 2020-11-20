using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed;
    void Start()
    {
        Speed = Random.Range(-0.08f, 0.08f);
    }
    void Update()
    {
        var size = transform.localScale.x;
        if (transform.position.y > 7)
        {
            transform.position = new Vector3(transform.position.x, (-5.90f + -(size - 1)), 0.0f);
        }
        if (transform.position.y < -6.00)
        {
            transform.position = new Vector3(transform.position.x, (6.9f + (size - 1)), 0.0f);
        }
        transform.Translate(0, Speed, 0f);
    }

}
