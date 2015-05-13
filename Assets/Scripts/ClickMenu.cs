using UnityEngine;
using System.Collections;

public class ClickMenu : MonoBehaviour
{

    public bool sound;
    GameObject soundButton, mainMenuButtons, settingsBackButton, muteImage, nomuteImage, pauseMenu;
    Mute backgroundMusic;
    private float savedTimeScale;
    private bool paused;
    // Use this for initialization
    void Start()
    {
        if (Application.loadedLevel == 0)
        {
            soundButton = GameObject.Find("Canvas/SoundButton");
            mainMenuButtons = GameObject.Find("Canvas/MainMenuButtons");
            muteImage = GameObject.Find("Canvas/SoundButton/Mute");
            nomuteImage = GameObject.Find("Canvas/SoundButton/Nomute");
            settingsBackButton = GameObject.Find("Canvas/BackButton");
            
            sound = PlayerPrefBool.GetBool("Sound");
            soundButton.SetActive(false);
            settingsBackButton.SetActive(false);
        }
        if (Application.loadedLevel == 1)
        {
            pauseMenu = GameObject.Find("Canvas/PauseMenu");
            pauseMenu.SetActive(false);
            paused = false;
        }
        
        backgroundMusic = GameObject.Find("BackgroundMusic").GetComponent<Mute>();
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
                if(!paused)Pause();
            }
            if (Application.loadedLevel == 0)
            {
                if (mainMenuButtons.activeSelf) Application.Quit();
                else CloseSettings();
            }
        }
    }
    void ResumeGame()
    {
        Time.timeScale = savedTimeScale;
        pauseMenu.SetActive(false);
        paused = false;
    }
    void Pause()
    {
        savedTimeScale = Time.timeScale;
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
        paused = true;
    }
    public void StartGame()
    {
        Time.timeScale = 1;
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
        mainMenuButtons.SetActive(false);
        soundButton.SetActive(true);
        ChangeSoundImage();
        settingsBackButton.SetActive(true);
    }
    public void CloseSettings()
    {
        mainMenuButtons.SetActive(true);
        soundButton.SetActive(false);
        settingsBackButton.SetActive(false);
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
