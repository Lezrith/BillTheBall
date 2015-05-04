using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreControl : MonoBehaviour
{
    public static int score;
    // Use this for initialization
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.Find("Canvas/Score").GetComponent<Text>().text="Score: " + score.ToString();
    }
}
