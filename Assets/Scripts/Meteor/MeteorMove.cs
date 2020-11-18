using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed;
    void Start()
    {
        Speed = Random.Range(-0.05f, 0.05f);
    }
    void Update()
    {       
        if (transform.position.y > 6.15)
        {
            transform.position = new Vector3(transform.position.x, -6.00f, 0.0f);
        }
        if (transform.position.y < -6.15)
        {
            transform.position = new Vector3(transform.position.x, 6.00f, 0.0f);
        }
        transform.Translate(0, Speed, 0f);
    }

}
