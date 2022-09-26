using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    private static TurnManager instance;
    [SerializeField] private PlayerTurn playerOne;
    [SerializeField] private PlayerTurn playerTwo;
    [SerializeField] private float timeBetweenTurns;

    private int currentPlayerIndex;
    private bool waitingForNextTurn;
    private float turnDelay;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            currentPlayerIndex = 1;
            playerOne.SetPlayerTurn(1);
            playerTwo.SetPlayerTurn(2);
        }
    }

    private void Update()
    {
        if (waitingForNextTurn)
        {
            turnDelay += Time.deltaTime;
            if (turnDelay >= timeBetweenTurns)
            {
                waitingForNextTurn = false;
                ChangeTurn();
                turnDelay = 0;
            }
        }
    }

    public bool IsItPlayerTurn(int index)
    {
        /*if (waitingForNextTurn)
        {
            Debug.LogError("False");
            return false;
        }*/

        return index == currentPlayerIndex;
    }

    public static TurnManager GetInstance()
    {
        return instance;
    }

    public void TriggerChangeTurn()
    {
        Debug.LogError("True");
        waitingForNextTurn = true;
    }

    public void ChangeTurn()
    {
        if (currentPlayerIndex == 1)
        {
            currentPlayerIndex = 2;
        }
        else if (currentPlayerIndex == 2)
        {
            currentPlayerIndex = 1;
        }
    }
}