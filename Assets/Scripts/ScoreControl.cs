using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreControl : MonoBehaviour
{
    public static int score;
    private int highScore;
    GameObject newRecord;
    float x, y, yStep, xStep;
    // Use this for initialization
    public void ZoomIn()
    {
        x = newRecord.transform.localScale.x;
        y = newRecord.transform.localScale.y;
        yStep = y / 25;
        xStep = x / 25;
        x -= xStep;
        y -= yStep;
        newRecord.transform.localScale = new Vector3(x, y, 0);
    }
    public void HighScore()
    {
        highScore = PlayerPrefs.GetInt("HighScore");
        newRecord = GameObject.Find("NewRecord");
        if (ScoreControl.score > highScore)
        {
            newRecord.transform.localScale = new Vector3(2 * newRecord.transform.localScale.x, 2 * newRecord.transform.localScale.y, 0);
            InvokeRepeating("ZoomIn", 0f, 0.01f);
            PlayerPrefs.SetInt("HighScore", ScoreControl.score);
            newRecord.GetComponent<SpriteRenderer>().enabled = true;
        }
    }
    void Start()
    {
        score = 0;
        //PlayerPrefs.SetInt("HighScore", ScoreControl.score);
    }

    // Update is called once per frame
    void Update()
    {
        if (x < 0.75f) CancelInvoke("ZoomIn");
        GameObject.Find("Canvas/Score").GetComponent<Text>().text = "Score: " + score.ToString();
    }
}
