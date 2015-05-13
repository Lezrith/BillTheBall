﻿using UnityEngine;
using System.Collections;

public class SpawnBlackHole : MonoBehaviour
{
    GameObject blackHole;
    public float spawnTime, delay;
    // Use this for initialization
    void Start()
    {
        blackHole = GameObject.Find("BlackHole");
        blackHole.SetActive(false);
        InvokeRepeating("MoveBlackHole", delay, spawnTime);
    }

    void MoveBlackHole()
    {
        if(!blackHole.activeSelf)
        {
            blackHole.SetActive(true);
            float x = Random.Range(-2.58f, 2.49f);
            float y = Random.Range(-3.5f, 3.57f);
            blackHole.transform.position = new Vector3(x, y, 0);
        }
        else
        {
            blackHole.SetActive(false);
        }
        if (!SpawnLaser.gameOver) CancelInvoke();
    }
}
