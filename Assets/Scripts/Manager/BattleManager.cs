using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    GameObject[] _players;
    GameObject[] _enemy;
    void Start()
    {
        
    }

    enum Turn
    {
        Start,
        Player,
        Enemy,
        End
    }

    GameObject[] GetEnemys()
    {
        return _enemy;
    }
}
