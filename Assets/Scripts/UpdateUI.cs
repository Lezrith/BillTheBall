using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpdateUI : MonoBehaviour
{
    GameObject yesButton, noButton, gameOver, tryAgain, score;
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
        score = GameObject.Find("Canvas/Score");
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
            score.transform.position = new Vector3(score.transform.position.x-15, Screen.height/2, 0);
            score.GetComponent<Text>().fontSize = 25;
        }
    }
}
