using UnityEngine;
using System.Collections;

public class PlayerPrefBool : MonoBehaviour
{
    static public void SetBool(string name, bool value)
    {
        PlayerPrefs.SetInt(name, value ? 1 : 0);
    }

    static public bool GetBool(string name)
    {
        return PlayerPrefs.GetInt(name) == 1 ? true : false;
    }
}
