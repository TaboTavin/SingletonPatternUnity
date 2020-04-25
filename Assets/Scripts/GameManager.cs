using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum GameState
{
    inGame,
    pause,
    gameOver
}
public class GameManager : MonoBehaviour
{

    public static GameManager sharedInstance;

    public GameState currentGameState = GameState.pause;

    private void Awake()
    {
        if (sharedInstance == null)
            sharedInstance = this;

        else
            Destroy(gameObject);
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
            StartGame();

        if (Input.GetKeyDown(KeyCode.P))
            PauseGame();
        
    }
    public void StartGame()
    {
        SetGameState(GameState.inGame);
    }

    public void PauseGame()
    {
        SetGameState(GameState.pause);
    }

    public void GameOver()
    {
        SetGameState(GameState.gameOver);
    }

    private void SetGameState(GameState newGameState)
    {
        if(newGameState == GameState.inGame)
        {
            //Logica para mostrar UI
        }

        else if(newGameState == GameState.pause)
        {
            //Logica para mostrar la pausa
        }

        else if(newGameState == GameState.gameOver)
        {
            //Logica para mostrar GameOver
        }

        this.currentGameState = newGameState;
    }
}
