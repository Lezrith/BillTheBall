﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayBestScore : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        gameObject.GetComponent<Text>().text = "Best: " + PlayerPrefs.GetInt("HighScore").ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
