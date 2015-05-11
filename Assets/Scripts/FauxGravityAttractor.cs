using UnityEngine;
using System.Collections;

public class FauxGravityAttractor : MonoBehaviour
{
    public float gravity = -5;
    public void Attract(GameObject body)
    {
        Vector3 distanceVector = (body.transform.position - this.transform.position);
        float distance = Vector3.Distance(body.transform.position, this.transform.position);
        //float radius = this.GetComponent<CircleCollider2D>().radius;
        //float procentage = distance / radius;
        Debug.Log(distanceVector.normalized * gravity/(distance*distance));
        body.GetComponent<Rigidbody2D>().AddForce(distanceVector.normalized * gravity / (distance*distance));
    }
}
