using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;
    public GameState State;
    public static event Action<GameState> OnGameStateChanged;

    private void Awake()
    {
        Instance = this;
    }

   
    // Start is called before the first frame update
    void Start()
    {
        UpdateGameStates(GameState.InMenu);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateGameStates(GameState newState) 
    {
        State = newState;

        switch (newState) 
        {
            case GameState.InMenu:
                break;
            case GameState.InShop:
                break;
            case GameState.InMainGameScreen:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
        }

        OnGameStateChanged?.Invoke(newState);
    }
}

public enum GameState 
{
    InMenu,
    InShop,
    InMainGameScreen

}