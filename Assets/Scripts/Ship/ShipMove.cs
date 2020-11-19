using Assets.Scripts;
using UnityEngine;

public class ShipMove : MonoBehaviour
{
    private int Score;
    public Quaternion originalRotationValue;
    public bool newMeteor;
    public bool hitMoon;
    public bool hitMeteor;
    public float timeLeft;
    private bool Lunch; 
    private void Awake()
    {
        timeLeft = 2.0f;
        Lunch = true;
        Score = 1;
        newMeteor = true;
        hitMeteor = false;
        hitMoon = false;
        GameObject.Find("Score").GetComponent<TextMesh>().text = $"STAGE {Score}";
    }
    void Update()
    {
        if (newMeteor)
        {
            new Meteor().Add(Score);
            newMeteor = false;
        }
        if (hitMeteor)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                Ship.Reset(gameObject);
                Moon.Reset();
                for (int i = 0; i < Score; i++)
                {
                    ResetMeteor(GameObject.Find($"Obstacles{i}"));
                }
                hitMeteor = false;
                newMeteor = true;
                Lunch = true;
                timeLeft = 2.0f;
                GameObject.Find("Score").GetComponent<TextMesh>().text = $"STAGE {Score}";
                GameObject.Find("Score").GetComponent<TextMesh>().color = Color.white;
            }
           
        }
        if (hitMoon)
        {
    
            timeLeft -= Time.deltaTime;
          
            if (timeLeft < 0)
            {
                Ship.Reset(gameObject);
                Moon.Reset();
                hitMoon = false;
                for (int i = 0; i < Score; i++)
                {
                    ResetMeteor(GameObject.Find($"Obstacles{i}"));
                }
                Score++;
                GameObject.Find("Score").GetComponent<TextMesh>().text = $"STAGE {Score}";
                GameObject.Find("Score").GetComponent<TextMesh>().color = Color.white;
                newMeteor = true;
                Lunch = true;
                timeLeft = 2.0f;
            }

        }
       
        if (Input.GetKeyUp(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            GetComponent<ConstantForce2D>().force = new Vector2(10, 0);
            Lunch = false;
        }
        if (Lunch)
        {
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
            {
                transform.Translate(0, Time.deltaTime * 15, 0f);
              
            }
            if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
            {
                transform.Translate(0, -Time.deltaTime * 15, 0f);
            }
        }

        if (transform.position.y > 6.15)
        {
            transform.position = new Vector3(transform.position.x, -6.15f, 0.0f);
        }
        else if (transform.position.y < -6.15)
        {
            transform.position = new Vector3(transform.position.x, 6.15f, 0.0f);
        }
        if (transform.position.x > 10f) 
        { 
            Score = 0;
            GameObject.Find("Score").GetComponent<TextMesh>().text = "GAMEOVER";
            GameObject.Find("Score").GetComponent<TextMesh>().color = Color.red;
            hitMeteor = true;
        }
    }
    private void OnTriggerExit2D(Collider2D hitedGameObjecto)
    {
        if (hitedGameObjecto.name.Contains("Meteor"))
        {
            gameObject.GetComponent<LineRenderer>().colorGradient = Utils.Gradient(Color.red, Color.red);
            hitedGameObjecto.GetComponent<LineRenderer>().colorGradient = Utils.Gradient(Color.red, Color.red);
            Score = 0;
            GameObject.Find("Score").GetComponent<TextMesh>().text = "GAMEOVER";
            GameObject.Find("Score").GetComponent<TextMesh>().color = Color.red;
            hitMeteor = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D hitedGameObjecto)
    {
        if (hitedGameObjecto.name.Contains("Moon"))
        {
            if (!hitMeteor)
            {
                Debug.Log("hit moon");
                gameObject.GetComponent<LineRenderer>().colorGradient = Utils.Gradient(Color.green, Color.green);
                hitMoon = true;
            }
        }
    }
    private static void ResetMeteor(GameObject meteor)
    {
        Destroy(meteor);
    }
}
