using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattlePlayer : CharacterBase
{
    [SerializeField]
    private PlayerData _playerData;

    protected override void Awake()
    {
        base.Awake();
    }

    protected override void Init()
    {
        _level = _playerData.Level;
        _attack = _playerData.Attack;
        _defense = _playerData.Defense;
        _speed = _playerData.Speed;
        _hp = _playerData.HP;
        _mp = _playerData.MP;
        _exP = _playerData.ExP;
        _gold = _playerData.Gold;
        _isPlayer = true;
        _skills = new List<SkillData>(_playerData.Skills.Length);
        for (int i = 0; i < _playerData.Skills.Length; i++)
        {
            _skills[i] = _playerData.Skills[i];
        }
    }

    public override void ReciveDamage(int damage)
    {
        _hp -= Calculator.Instance.DamageCalculation(damage, _defense);
    }

    public override void SelectAction()
    {

    }

    protected override void PlayAction()
    {

    }
}
