using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BattleManager : MonoBehaviour
{
    GameObject[] _players;
    GameObject[] _enemy;

    public event Action PlayersAction;
    void Start()
    {
        
    }

    enum Turn
    {
        Start,
        PlayerActionDecision,
        Action,
        End
    }

    GameObject[] GetEnemys()
    {
        return _enemy;
    }
}
