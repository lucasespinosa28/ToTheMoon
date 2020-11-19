using Assets.Scripts;
using UnityEngine;

namespace Assets.Scripts
{
    public class ScoreText
    {
        public static GameObject scoreObject = GameObject.Find("ScoreText");
        public static void GameOver(ref int Score)
        {
            Score = 1;
            scoreObject.GetComponent<TextMesh>().text = "GAMEOVER";
            scoreObject.GetComponent<TextMesh>().color = Color.red;
        }
        public static void UpdateScore(ref int Score)
        {
            Score++;
            scoreObject.GetComponent<TextMesh>().text = $"STAGE {Score}";
            scoreObject.GetComponent<TextMesh>().color = Color.white;
        }
        public static void Reset()
        {
            scoreObject.GetComponent<TextMesh>().text = $"STAGE 1";
            scoreObject.GetComponent<TextMesh>().color = Color.white;
        }
    }
}
