using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMove : MonoBehaviour
{
    // Start is called before the first frame update
    public (float,float) MinMaxSpeed;
    public float MinSpeed;
    private float Speed;
    void Start()
    {
        //var Up = Random.Range(MaxSpeed - (MaxSpeed * 2), MaxSpeed);
       // var Down = Random.Range(MinSpeed - (MinSpeed * 2), MinSpeed);
       // Speed = Random.Range(MinMaxSpeed.Item1 - (MaxSpeed * 2), MaxSpeed);
        if (Random.Range(0,10) % 2 == 0)
        {
            Speed = Random.Range(MinMaxSpeed.Item1, MinMaxSpeed.Item2);
        }
        else
        {
            Speed = Random.Range(MinMaxSpeed.Item1 - (MinMaxSpeed.Item1 * 2), MinMaxSpeed.Item2 - (MinMaxSpeed.Item2 * 2)); ;
        }
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
