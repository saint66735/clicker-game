using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject SettingsPanel;
    public GameObject ModsPanel;
    public GameObject StartPanel;
    public GameObject SavePanel;
    public bool loaded = false;
    bool ingame = false;
    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (SettingsPanel.activeInHierarchy)
            {
                SettingsPanel.SetActive(false);
                SavePanel.SetActive(false);
            }
            else
            {
                SettingsPanel.SetActive(true);
                SavePanel.SetActive(true);
            }
        }
    }
    public void OnExitGame()
    {
        if (ingame)
            Save.instance.SaveFile();
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

        if (Save.instance.LoadFile())
        {
            StartPanel.SetActive(false);
            SettingsPanel.SetActive(false);
            SceneManager.LoadScene(1);
            loaded = true;
            ingame = true;
        }
    }
    public void OnStartNewGame()
    {
        StartPanel.SetActive(false);
        SettingsPanel.SetActive(false);
        SceneManager.LoadScene(1);
        ClearSaveData();
        ingame = true;
    }
    public void ClearSaveData()
    {
        Save.instance.NewGame();
    }
    public void OnSelectModsMenu()
    {

    }
    public void OnSelectMod()
    {

    }
    public void OnSave()
    {
        Save.instance.SaveFile();
    }
    public void Setup()
    {

    }

}
