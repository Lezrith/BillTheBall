using UnityEngine;
using System.Collections;

public class RevertGravity : MonoBehaviour
{
    float currentPobability;
    int rand;
    int time;
    public int meanTime;
    // Use this for initialization
    void Start()
    {
        time = 0;
    }
    void Update()
    {
        time++;
        rand = Random.Range(1, 100);
        currentPobability = 1 - Mathf.Pow(2, -time / meanTime);
        if(rand<currentPobability*100)
        {
            time = 0;
            Revert();
        }
        //Debug.Log((currentPobability * 100).ToString());
    }
    public void Revert()
    {
        Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
        rb.gravityScale = -rb.gravityScale;
    }
}
