using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpdateUI : MonoBehaviour
{
    GameObject yesButton, noButton, gameOver, tryAgain, scoreGUI;
    
    // Use this for initialization
    void Start()
    {
        
        yesButton = GameObject.Find("Canvas/YesButton");
        yesButton.SetActive(false);
        noButton = GameObject.Find("Canvas/NoButton");
        noButton.SetActive(false);
        gameOver = GameObject.Find("Canvas/GameOver");
        gameOver.SetActive(false);
        tryAgain = GameObject.Find("Canvas/TryAgain");
        tryAgain.SetActive(false);
        scoreGUI = GameObject.Find("Canvas/Score");
    }

    // Update is called once per frame
    void Update()
    {
        if(SpawnLaser.gameOver && !yesButton.activeSelf)
        {
            yesButton.SetActive(true);
            noButton.SetActive(true);
            gameOver.SetActive(true);
            tryAgain.SetActive(true);
            scoreGUI.transform.position = new Vector3(scoreGUI.transform.position.x-15, Screen.height/2, 0);
            scoreGUI.GetComponent<Text>().fontSize = 25;
            GameObject.Find("Main Camera").GetComponent<ScoreControl>().HighScore();
        }
    }
}
