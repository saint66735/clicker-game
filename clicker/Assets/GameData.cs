using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData 
{
    public float yen;
    public int petals;
    public int building1Count;
    public int building2Count;
    public int building3Count;
    public Time endTime;

    public GameData(float yen, int petals, int building1Count, int building2Count, int building3Count, Time endTime)
    {
        this.yen = yen;
        this.petals = petals;
        this.building1Count = building1Count;
        this.building2Count = building2Count;
        this.building3Count = building3Count;
        this.endTime = endTime;
    }
}
