using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BattleEnemy : CharacterBase
{
    [SerializeField]
    private EnemyData _enemyData;

    private Action _action;

    protected override void Awake()
    {
        base.Awake();
    }

    protected override void Init()
    {
        _level = _enemyData.Level;
        _name = _enemyData.Name;
        _attack = _enemyData.Attack;
        _defense = _enemyData.Defense;
        _speed = _enemyData.Speed;
        _hp = _enemyData.HP;
        _mp = _enemyData.MP;
        _exp = _enemyData.ExP;
        _gold = _enemyData.Gold;
        _isPlayer = false;
        _skills = new List<SkillData>(_enemyData.Skills.Length);
        for(int i = 0; i < _enemyData.Skills.Length; i++)
        {
            _skills[i] = _enemyData.Skills[i];
        }
    }

    public override void ReciveDamage(int damage)
    {
        var d = Calculator.DamageCalculation(damage, _defense);
        _hp -= d;
        Debug.Log(_name + "‚Í" + d + "ƒ_ƒ[ƒW‚ðŽó‚¯‚½");
    }

    public override void SelectAction()
    {
        _action = () => BattleManager.Instance.Player.ReciveDamage(_attack);
    }

    public override void PlayAction()
    {
        _action?.Invoke();
    }
}
