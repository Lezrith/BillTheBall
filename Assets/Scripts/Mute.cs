using UnityEngine;
using System.Collections;

public class Mute : MonoBehaviour
{
    public void OnLevelWasLoaded(int level)
    {
        if (!PlayerPrefBool.GetBool("Sound")) gameObject.GetComponent<AudioSource>().enabled = false;
    }
}
