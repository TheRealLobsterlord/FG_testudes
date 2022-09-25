using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Battle { Start, Player1Turn, Player2Turn, Won, Lost }

public class TurnManager : MonoBehaviour
{
    public CharacterController script;
    public GameObject Player1;
    public GameObject Player2;

    public Transform P1Location;
    public Transform P2Location;

    Unit player1Unit;
    Unit player2Unit;

    public Battle state;
    public void Start()
    {
        state = Battle.Start;
        StartCoroutine(SetupBattle());
    }

    IEnumerator SetupBattle()
    {
       GameObject P1Go = Instantiate(Player1, P1Location);
        player1Unit = P1Go.GetComponent<Unit>();

       GameObject P2Go = Instantiate(Player2, P2Location);
        player2Unit = P2Go.GetComponent<Unit>();

        yield return new WaitForSeconds(3f);

        state = Battle.Player1Turn;
        Player1Turn();
    }

    public void Player1Turn()
    {
        if (state != Battle.Player1Turn)
            return;
        bool IsMyTurn = true;
    }

}


