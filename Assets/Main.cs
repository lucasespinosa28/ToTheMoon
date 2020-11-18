using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    // Creates a line renderer that follows a Sin() function
    // and animates it.
    public int NumberOfObstacle;
    public List<ObstaclesMove> Obstacles = new List<ObstaclesMove>();
    public GameObject Moon, Ship;
    public float Test1;
    public float Test2;
    public float speed;
    void Start()
    {
        Test1 = 5.5f;
        Test2 = -5.5f;
        NumberOfObstacle = 9;
        Moon = Objects.AddGoal();
        Ship = Objects.AddPlayer();
        Objects.AddObstacles(NumberOfObstacle);
        //for (int l = 0; l < 2; l++)
        //{
        //    for (int i = 0; i < NumberOfObstacle; i++)
        //    {
        //        Obstacles.Add(new ObstaclesMove
        //        {
        //            Speed = Random.Range(-0.05f, 0.05f),
        //            Obstacles = GameObject.Find("Obstacles" + i),
        //        });
        //    }
        //}
        //foreach (var item in Obstacles)
        //{
          
        //}
       

    }
    void Update()
    {
        if (Input.GetKeyUp("space"))
        {
            Ship.GetComponent<ConstantForce2D>().force = new Vector2(10, 0);
        }
        if (Ship.transform.position.y > 6.15)
        {
            Ship.transform.position = new Vector3(Ship.transform.position.x, -6.15f, 0.0f);
        }
        else if (Ship.transform.position.y < -6.15) 
        {
            Ship.transform.position = new Vector3(Ship.transform.position.x, 6.15f, 0.0f);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            float atualPossitionY = Ship.transform.position.y;
            Debug.Log("Up");
            Ship.transform.Translate(0, Time.deltaTime * 15, 0f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            float atualPossitionY = Ship.transform.position.y;
            Debug.Log("Down");
            Ship.transform.Translate(0, -Time.deltaTime * 15, 0f); 
        }

        Moon.transform.Translate(Vector3.up * Time.deltaTime);
        if (Moon.transform.position.y > 7.5)
        {
            Moon.transform.position = new Vector3(Moon.transform.position.x, -7.5f, 0.0f);
        }
    }
}

public class ObstaclesMove
{
    public GameObject Obstacles;
    public float Speed;
}