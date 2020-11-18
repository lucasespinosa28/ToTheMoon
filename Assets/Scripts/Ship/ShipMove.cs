using Assets.Scripts;
using UnityEngine;

public class ShipMove : MonoBehaviour
{
    private int Score = 1;
    public Quaternion originalRotationValue;
    public bool newMeteor;
    public bool hitMoon;
    public bool hitMeteor;
    public float timeLeft = 2.0f;
    private void Awake()
    {
        newMeteor = true;
        hitMeteor = false;
        hitMoon = false;
        GameObject.Find("Score").GetComponent<TextMesh>().text = "$STAGE {Score}";
    }
    void Update()
    {
        if (newMeteor)
        {
            new Meteor().Add(9);
            newMeteor = false;
        }
        if (hitMeteor)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                ResetShip(gameObject);
                for (int i = 0; i < 9; i++)
                {
                    ResetMeteor(GameObject.Find($"Obstacles{i}"));
                }
                hitMeteor = false;
                newMeteor = true;
                timeLeft = 2.0f;
                GameObject.Find("Score").GetComponent<TextMesh>().text = $"STAGE {Score}";
            }
           
        }
        if (hitMoon)
        {
    
            timeLeft -= Time.deltaTime * 100;
            if (timeLeft < 0)
            {
                ResetShip(gameObject);
                GameObject.Find("MoonPosition").transform.position = new Vector3(7.50f, 0.00f, 00f);
                hitMoon = false;
                for (int i = 0; i < 9; i++)
                {
                    ResetMeteor(GameObject.Find($"Obstacles{i}"));
                }
                Score++;
                GameObject.Find("Score").GetComponent<TextMesh>().text = $"STAGE {Score}";
                newMeteor = true;
                timeLeft = 2.0f;
            }

        }
       
        if (Input.GetKeyUp(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            GetComponent<ConstantForce2D>().force = new Vector2(10, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, Time.deltaTime * 15, 0f);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -Time.deltaTime * 15, 0f);
        }

        if (transform.position.y > 6.15)
        {
            transform.position = new Vector3(transform.position.x, -6.15f, 0.0f);
        }
        else if (transform.position.y < -6.15)
        {
            transform.position = new Vector3(transform.position.x, 6.15f, 0.0f);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.name.Contains("Moon"))
        {
            if (!hitMeteor)
            {
                hitMoon = true;              
            }
        }
        if (other.name.Contains("Meteor"))
        {
            Score = 0;
            GameObject.Find("Score").GetComponent<TextMesh>().text = "GAMEOVER";
            hitMeteor = true;
        }
    }
    private static void ResetShip(GameObject ship)
    {
        ship.transform.position = new Vector3(-7.50f, 0.00f, 00f);
        ship.GetComponent<ConstantForce2D>().force = new Vector2(0, 0);
        ship.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        ship.transform.rotation = Quaternion.identity;
        ship.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
    }
    private static void ResetMeteor(GameObject meteor)
    {
        Destroy(meteor);
    }
}
