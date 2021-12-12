using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject SettingsPanel;
    public GameObject ModsPanel;
    public GameObject StartPanel;
    public Save save = new Save();
    bool inGame = false;
    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    public void OnExitGame()
    {
        Application.Quit();
    }
    public void OnSettingsClick()
    {

    }
    public void OnSettingsApply()
    {

    }
    public void OnLoadGame()
    {
        SceneManager.LoadScene(1);
        save.LoadFile();
    }
    public void OnStartNewGame()
    {
        SceneManager.LoadScene(1);
        ClearSaveData();
    }
    public void ClearSaveData()
    {
        save.NewGame();
    }
    public void OnSelectModsMenu()
    {

    }
    public void OnSelectMod()
    {

    }
    public void Setup()
    {

    }
}
