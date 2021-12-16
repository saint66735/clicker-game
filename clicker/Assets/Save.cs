using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public class Save : MonoBehaviour
{
    float currentYen;
    int currentPetals;
    int currentPassiveIncomeCount;
    int currentActiveIncomeCount;
    public static Save instance = null;
    GameData currentState;
    
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }
    /*public void GetState()
    {
        GameData temp = GameManager2.instance.UpdateState();
        if (currentState == null || !currentState.Equals(temp))
        {
            currentState = temp;
            dirtyFlag = true;
        }
        else
        {
            dirtyFlag = false;
        }
    }*/
    public void SaveFile()
    {
        currentState = CurrentState.instance.CaptureState();
        if (CurrentState.instance.dirtyFlag)
        {
            string destination = Application.persistentDataPath + "/save.dat";
            FileStream file;

            if (File.Exists(destination)) file = File.OpenWrite(destination);
            else file = File.Create(destination);

            GameData data = currentState;
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(file, data);
            file.Close();
        }
        else
        {
            Debug.Log("Nuffin changed");
        }
    }

    public bool LoadFile()
    {
        string destination = Application.persistentDataPath + "/save.dat";
        FileStream file;

        if (File.Exists(destination)) file = File.OpenRead(destination);
        else
        {
            Debug.LogError("File not found");
            return false;
        }

        BinaryFormatter bf = new BinaryFormatter();
        GameData data = (GameData)bf.Deserialize(file);
        file.Close();

        currentYen = data.yen;
        currentPetals = data.petals;
        currentPassiveIncomeCount = data.passiveBuildingCount;
        currentActiveIncomeCount = data.activeBuildingCount;
        currentState = data;
        CurrentState.instance.currentState = data;
        return true;
    }
    public void NewGame()
    {
        string destination = Application.persistentDataPath + "/save.dat";

        if (File.Exists(destination)) File.Delete(destination);
    }
    public void ApplyLoad()
    {
        GameManager2.instance.building1Count = currentPassiveIncomeCount;
        GameManager2.instance.building2Count = currentActiveIncomeCount;
        GameManager2.instance.score = currentYen;
        AktyviosPrekes.instance.VisosAktyviosPrekes = currentActiveIncomeCount;
        PasyviosPrekes.instance.VisosPasyviosPrekes = currentPassiveIncomeCount;
    }
}
