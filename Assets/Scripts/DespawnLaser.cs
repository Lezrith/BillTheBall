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
        Invoke("Enable", enableTime);
    }
    // Update is called once per frame
    void Enable()
    {
        GetComponent<AudioSource>().Play();
        gameObject.GetComponentInChildren<BoxCollider2D>().enabled = true;
        gameObject.GetComponentInChildren<SpriteRenderer>().enabled = true;
        if (!scoreAdded && !SpawnLaser.gameOver)
        {
            ScoreControl.score++;
            scoreAdded = true;
        }
    }
}
