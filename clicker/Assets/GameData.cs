using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[System.Serializable]
public class GameData : IEquatable<GameData>
{
    public float yen;
    public int petals;
    public int building1Count;
    public int building2Count;
    public int building3Count;

    public GameData(float yen, int petals, int building1Count, int building2Count, int building3Count)
    {
        this.yen = yen;
        this.petals = petals;
        this.building1Count = building1Count;
        this.building2Count = building2Count;
        this.building3Count = building3Count;
    }

    public bool Equals(GameData other)
    {
        if (yen == other.yen && building1Count == other.building1Count && building2Count == other.building2Count && building3Count == other.building3Count)
            return true;
        return false;
    }
}
