using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentState : MonoBehaviour
{
    public static CurrentState instance = null;
    GameData currentState;
    public bool dirtyFlag = false;
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
    public GameData CaptureState()
    {
        GameData temp = GameManager2.instance.UpdateState();
        temp.passiveBuildingCount = PasyviosPrekes.instance.VisosPasyviosPrekes;
        temp.activeBuildingCount = AktyviosPrekes.instance.VisosAktyviosPrekes;
        if (currentState.Equals(temp) || currentState != null)
            dirtyFlag = false;
        else
        {
            dirtyFlag = true;
            currentState = temp;
        }

        return temp;
    }
}
