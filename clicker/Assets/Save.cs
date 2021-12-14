using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public class Save : MonoBehaviour
{
    float currentYen;
    int currentPetals;
    int currentBuilding1Count;
    int currentBuilding2Count;
    int currentBuilding3Count;
    public static Save instance = null;
    GameData currentState;
    bool dirtyFlag = true;
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
    public void GetState()
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
    }
    public void SaveFile()
    {
        GetState();
        if (dirtyFlag)
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
        currentBuilding1Count = data.building1Count;
        currentBuilding1Count = data.building2Count;
        currentBuilding1Count = data.building3Count;
        currentState = data;
        return true;
    }
    public void NewGame()
    {
        string destination = Application.persistentDataPath + "/save.dat";

        if (File.Exists(destination)) File.Delete(destination);
    }
    public void ApplyLoad(GameManager2 instance)
    {
        instance.building1Count = currentBuilding1Count;
        instance.building1Count = currentBuilding2Count;
        instance.building1Count = currentBuilding3Count;
        instance.score = currentYen;
    }
}
