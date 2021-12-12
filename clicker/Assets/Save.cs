using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public class Save
{
     float currentYen;
     int currentPetals;
     int currentBuilding1Count;
     int currentBuilding2Count;
     int currentBuilding3Count;

    public void SaveFile()
    {
        string destination = Application.persistentDataPath + "/save.dat";
        FileStream file;

        if (File.Exists(destination)) file = File.OpenWrite(destination);
        else file = File.Create(destination);

        GameData data = new GameData(currentYen, currentPetals, currentBuilding1Count, currentBuilding2Count, currentBuilding3Count);
        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(file, data);
        file.Close();
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
        return true;
    }
    public void NewGame()
    {
        string destination = Application.persistentDataPath + "/save.dat";

        if (File.Exists(destination)) File.Delete(destination);
    }
}
