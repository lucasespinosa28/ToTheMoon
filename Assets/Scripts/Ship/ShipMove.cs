using Assets.Scripts;
using UnityEngine;

public class ShipMove : MonoBehaviour
{
    private int Score;
    public Quaternion originalRotationValue;
    public bool newMeteor, hitMoon, hitMeteor, launchable;
    public float timeLeft;
    private void Awake()
    {
        timeLeft = 2.0f;
        launchable = true;
        Score = 1;
        newMeteor = true;
        hitMeteor = false;
        hitMoon = false;
        GameObject.Find("ScoreText").GetComponent<TextMesh>().text = $"STAGE {Score}";
      

    }
//6 max meteors
void Update()
    {
        if (newMeteor)
        {
                new Moon();
            
                Stages.Level(Score);
               // new Meteor().AddLegacy(i);

            newMeteor = false;
        }
        if (hitMeteor)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                Ship.Reset(gameObject);
                for (int i = 0; i < 10; i++)
                {
                    ResetMeteor();
                }
                hitMeteor = false;
                newMeteor = true;
                launchable = true;
                timeLeft = 2.0f;
                Destroy(GameObject.Find("MoonPosition"));
                ScoreText.Reset();
            }
           
        }
        if (hitMoon)
        {
    
            timeLeft -= Time.deltaTime * 5;
          
            if (timeLeft < 0)
            {
                Ship.Reset(gameObject);
                hitMoon = false;
                
                    ResetMeteor();
                
                newMeteor = true;
                launchable = true;
                Destroy(GameObject.Find("MoonPosition"));
                ScoreText.UpdateScore(ref Score);
                timeLeft = 2.0f;
            }

        }
        bool SpaceKey = Input.GetKeyUp(KeyCode.Space);
        Ship.Lunch(SpaceKey,gameObject, ref launchable);

        bool UpKey = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W);
        Ship.Control.Up(UpKey, gameObject, ref launchable);

        bool DownKey = Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S);
        Ship.Control.Down(DownKey, gameObject, ref launchable);
        Ship.OffScreen(gameObject,ref hitMeteor,ref hitMeteor,ref Score);
        
       
    }
    private void OnTriggerExit2D(Collider2D hitedGameObjecto)
    {
        if (hitedGameObjecto.name.Contains("Meteor"))
        {
            gameObject.GetComponent<LineRenderer>().colorGradient = Utils.Gradient(Color.red, Color.red);
            hitedGameObjecto.GetComponent<LineRenderer>().colorGradient = Utils.Gradient(Color.red, Color.red);
            Score = 0;
            ScoreText.GameOver(ref Score);
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
                hitedGameObjecto.GetComponent<LineRenderer>().colorGradient = Utils.Gradient(Color.green, Color.green);
                hitMoon = true;
            }
        }
    }
    private static void ResetMeteor()
    {
        for (int i = 0; i < 10; i++)
        {
            Destroy(GameObject.Find($"Meteor{i}"));
        }
    }
}
