using UnityEngine;
using System.Collections;

public class SpawnLaser : MonoBehaviour
{
    public float spawnTime, waitTime;
    public GameObject laser;
    float spawnY, spawnX;
    Vector3 spawnPlace;
    Quaternion rotation;
    public static bool gameOver;
    // Use this for initialization
    void Start()
    {
        gameOver = false;
        InvokeRepeating("Spawn", waitTime, spawnTime);
    }

    // Update is called once per frame
    void Spawn()
    {
        if (!gameOver)
        {
            int direction = Random.Range(1, 4);
            switch (direction)
            {
                case 1:
                    spawnY = Random.Range(-3.13f, 4.35f);
                    spawnPlace = new Vector3(0.63f, spawnY, 0);
                    rotation = Quaternion.Euler(0, 0, 0);
                    break;
                case 2:
                    spawnX = Random.Range(-1.66f, 3.34f);
                    spawnPlace = new Vector3(spawnX, 0.36f, 0);
                    rotation = Quaternion.Euler(0, 0, 270);
                    break;
                case 3:
                    spawnY = Random.Range(-3.13f, 4.35f);
                    spawnPlace = new Vector3(-0.63f, spawnY, 0);
                    rotation = Quaternion.Euler(0, 0, 180);
                    break;
            }
            Instantiate(laser, spawnPlace, rotation);
        }
    }
}
