using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : SingletonMonoBehaviour<BattleManager>
{
    public IReadOnlyList<BattlePlayer> Players => _players;

    //public IReadOnlyList<Enemy> Enemys => _enemys;

    private List<BattlePlayer> _players = new List<BattlePlayer>();

    //private List<Enemy> _enemys = new List<Enemy>();

    protected override void Awake()
    {
        base.Awake();
    }

    public void Register(CharacterBase characterBase, bool isPlayer)
    {
        if (isPlayer)
        {
            _players.Add(characterBase as  BattlePlayer);
        }
        else
        {

        }
    }
}
