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
    public float price1;
    public float price2;

    public GameData(float yen, int petals, int passiveBuildingCount, int activeBuildingCount, float price1, float price2)
    {
        this.yen = yen;
        this.petals = petals;
        this.passiveBuildingCount = passiveBuildingCount;
        this.activeBuildingCount = activeBuildingCount;
        this.price1 = price1;
        this.price2 = price2;
    }

    public bool Equals(GameData other)
    {
        if (yen == other.yen && passiveBuildingCount == other.passiveBuildingCount && activeBuildingCount == other.activeBuildingCount )
            return true;
        return false;
    }
}
