using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource soundButton;
    public void HandlePlayButtonOnClickEvent()
    {
        SceneManager.LoadScene("PlayScene");
        soundButton.Play();
    }

    public void HandleQuitButtonOnClickEvent()
    {
        Application.Quit();
        soundButton.Play();
    }
}
