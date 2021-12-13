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
    Save save;
    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        save = FindObjectOfType<Save>();
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

        if (save.LoadFile())
        {
            StartPanel.SetActive(false);
            SettingsPanel.SetActive(false);
            SceneManager.LoadScene(1);
        }
    }
    public void OnStartNewGame()
    {
        StartPanel.SetActive(false);
        SettingsPanel.SetActive(false);
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
    public void Save()
    {
        save.GetState();
        save.SaveFile();
    }
    public void Setup()
    {

    }

}
