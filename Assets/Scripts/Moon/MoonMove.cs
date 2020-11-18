using UnityEngine;

    // Start is called before the first frame update
public class MoonMove : MonoBehaviour
{

    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime);
        if (transform.position.y > 7.5)
        {
            transform.position = new Vector3(transform.position.x, -7.5f, 0.0f);
        }
    }
}

