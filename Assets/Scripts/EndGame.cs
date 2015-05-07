using UnityEngine;
using System.Collections;

public class EndGame : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "LaserMain")
        {
            SpawnLaser.gameOver = true;
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            Destroy(gameObject,0.1f);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
