using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject SettingsPanel;
    public GameObject ModsPanel;
    public GameObject StartPanel;
    bool inGame = false;
    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    public void OnStartGame()
    {

    }
    public void OnExitGame()
    {
        Application.Quit();
    }
    public void OnSettingsClick()
    {

    }
    public void OnLoadGame()
    {

    }
    public void OnStartNewGame()
    {

    }
    public void OnSelectModsMenu()
    {

    }
    public void OnSelectMod()
    {

    }
}
