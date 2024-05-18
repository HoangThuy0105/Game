using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMangament : MonoBehaviour
{
    string ScoreKey = "Score";
    
    void Start()
    {
        LoadPref();
        
    }
    void OnApplicationQuit()
    {
        SavePref();
    }
    public void SavePref()
    {
        PlayerPrefs.SetInt(ScoreKey, MenuManager.Instance.CurrentScore);
        PlayerPrefs.Save();
    }   

    public void LoadPref()
    {
        var socre = PlayerPrefs.GetInt(ScoreKey, 0);
        MenuManager.Instance.CurrentScore = socre;
        
    }
}
