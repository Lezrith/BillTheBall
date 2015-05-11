using UnityEngine;
using System.Collections;

public class DontDestroy : MonoBehaviour
{

    // Use this for initialization
    void Awake()
    {
        if (GameObject.FindGameObjectsWithTag("BackgroundMusic").Length > 1)Destroy(this.gameObject);
        DontDestroyOnLoad(gameObject);
    }
}
