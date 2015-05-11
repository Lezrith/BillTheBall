using UnityEngine;
using System.Collections;

public class ScaleObject : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        float targetaspect = 4.5f / 6.0f;
        float windowaspect = (float)Screen.width / (float)Screen.height;
        float scaleheight = windowaspect / targetaspect;
        this.transform.localScale = new Vector3(this.transform.localScale.x, this.transform.localScale.y * scaleheight, this.transform.localScale.z);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
