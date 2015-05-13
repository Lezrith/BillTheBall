using UnityEngine;
using System.Collections;

public class Mute : MonoBehaviour
{
    public void OnLevelWasLoaded(int level)
    {
        gameObject.GetComponent<AudioSource>().enabled = PlayerPrefBool.GetBool("Sound");
    }
}
