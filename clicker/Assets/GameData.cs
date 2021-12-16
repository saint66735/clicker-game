using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[System.Serializable]
public class GameData : IEquatable<GameData>
{
    public float yen;
    public int petals;
    public int passiveBuildingCount;
    public int activeBuildingCount;

    public GameData(float yen, int petals, int building1Count, int building2Count)
    {
        this.yen = yen;
        this.petals = petals;
        this.passiveBuildingCount = building1Count;
        this.activeBuildingCount = building2Count;
    }

    public bool Equals(GameData other)
    {
        if (yen == other.yen && passiveBuildingCount == other.passiveBuildingCount && activeBuildingCount == other.activeBuildingCount )
            return true;
        return false;
    }
}
