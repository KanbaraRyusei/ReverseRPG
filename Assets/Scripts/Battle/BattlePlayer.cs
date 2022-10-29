using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattlePlayer : CharacterBase
{
    //[SerializeField]
    //private PlayerData _playerData;

    protected override void Awake()
    {
        base.Awake();
    }

    protected override void Init()
    {

    }

    public override void ReciveDamage(int damage)
    {
        _hp -= Calculator.Instance.DamageCalculation(damage, _defensePower);
    }
}
