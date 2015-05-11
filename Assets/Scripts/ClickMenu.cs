using UnityEngine;
using System.Collections;

public class ClickMenu : MonoBehaviour
{
    
    public bool sound;
    GameObject soundButton, startButton, exitButton, settingsButton, backButton, muteImage, nomuteImage;
    Mute backgroundMusic;
    // Use this for initialization
    void Start()
    {
        backButton = GameObject.Find("Canvas/BackButton");
        soundButton = GameObject.Find("Canvas/SoundButton");
        startButton = GameObject.Find("Canvas/StartButton");
        exitButton = GameObject.Find("Canvas/ExitButton");
        settingsButton = GameObject.Find("Canvas/SettingsButton");
        muteImage = GameObject.Find("Canvas/SoundButton/Mute");
        nomuteImage = GameObject.Find("Canvas/SoundButton/Nomute");
        backgroundMusic = GameObject.Find("BackgroundMusic").GetComponent<Mute>();
        if (Application.loadedLevel == 0)
        {
            sound = PlayerPrefBool.GetBool("Sound");
            soundButton.SetActive(false);
            backButton.SetActive(false);
        }
        MuteUnmute();
    }

    private void MuteUnmute()
    {
        backgroundMusic.OnLevelWasLoaded(0);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Application.loadedLevel == 1)
            {
                Application.LoadLevel(0);
            }
            if (Application.loadedLevel == 0)
            {
                Application.Quit();
            }
        }
    }
    public void StartGame()
    {
        Application.LoadLevel(1);
    }
    public void CloseGame()
    {
        Application.Quit();
    }
    public void GoToMenu()
    {
        Application.LoadLevel(0);
    }
    public void OpenSettings()
    {
        startButton.SetActive(false);
        exitButton.SetActive(false);
        soundButton.SetActive(true);
        ChangeSoundImage();
        settingsButton.SetActive(false);
        backButton.SetActive(true);
    }
    public void CloseSettings()
    {
        startButton.SetActive(true);
        exitButton.SetActive(true);
        soundButton.SetActive(false);
        settingsButton.SetActive(true);
        backButton.SetActive(false);
    }

    private void ChangeSoundImage()
    {
        if (!sound)
        {
            muteImage.SetActive(true);
            nomuteImage.SetActive(false);
        }
        else
        {
            nomuteImage.SetActive(true);
            muteImage.SetActive(false);
        }
    }
    public void FlipSound()
    {
        sound = !sound;
        PlayerPrefBool.SetBool("Sound", sound);
        ChangeSoundImage();
        MuteUnmute();
    }
}
