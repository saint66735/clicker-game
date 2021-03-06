using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentState : MonoBehaviour
{
    public static CurrentState instance = null;
    public GameData currentState;
    public bool dirtyFlag = true;
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
        if (!currentState.Equals(temp) || currentState == null)
        {
            dirtyFlag = true;
            currentState = temp;
        }
        else
            dirtyFlag = false;

        return temp;
    }
}
