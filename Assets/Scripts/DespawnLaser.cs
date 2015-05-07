using UnityEngine;
using System.Collections;

public class DespawnLaser : MonoBehaviour
{
    public float destructionTime, enableTime;
    private float spawnTime;
    private bool scoreAdded = false;
    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, destructionTime);
        spawnTime = Time.time;
    }
    // Update is called once per frame
    void Update()
    {
        if (Time.time - spawnTime > enableTime)
        {
            gameObject.GetComponentInChildren<BoxCollider2D>().enabled = true;
            gameObject.GetComponentInChildren<SpriteRenderer>().enabled = true;
            if (!scoreAdded && !SpawnLaser.gameOver)
            {
                ScoreControl.score++;
                scoreAdded = true;
            }
        }
    }
}
