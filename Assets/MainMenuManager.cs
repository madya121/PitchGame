using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public Dropdown micDropdown;
    
    public void Start()
    {
        if (Microphone.devices.Length > 0)
        {
            PlayerPrefs.SetString("Mic", Microphone.devices[0]);
            PlayerPrefs.Save();
            
            micDropdown.ClearOptions();
            micDropdown.AddOptions(new List<String>(Microphone.devices));
        }
    }

    public void GoToSongSelection()
    {
        SceneManager.LoadScene("Song Selection");
    }

    public void GoToPractice()
    {
        SceneManager.LoadScene("Learning Module");
    }

    public void MicSelected(Dropdown d)
    {
        PlayerPrefs.SetString("Mic", d.options[d.value].text);
        Debug.Log(PlayerPrefs.GetString("Mic"));
        PlayerPrefs.Save();
    }
}
