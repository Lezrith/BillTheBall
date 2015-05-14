using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpdateUI : MonoBehaviour
{
    GameObject gameOverMenu, scoreGUI;

    // Use this for initialization
    void Start()
    {
        gameOverMenu = GameObject.Find("Canvas/EndGameMenu");
        gameOverMenu.SetActive(false);
        scoreGUI = GameObject.Find("Canvas/Score");
    }

    public void ShowGameOver()
    {
        gameOverMenu.SetActive(true);
        scoreGUI.transform.position = new Vector3(scoreGUI.transform.position.x, Screen.height / 2, 0);
        scoreGUI.GetComponent<Text>().fontSize = 25;
        GameObject.Find("Main Camera").GetComponent<ScoreControl>().HighScore();
    }
}
