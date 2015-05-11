using UnityEngine;
using System.Collections;

public class FauxGravityBody : MonoBehaviour
{
    public FauxGravityAttractor attractor;
    private GameObject body;
    // Use this for initialization
    void Start()
    {
        body = gameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay2D(Collider2D col)
    {
        attractor.Attract(body);
    }
}
