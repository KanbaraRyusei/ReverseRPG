using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattlePlayer : CharacterBase
{
    protected override void Awake()
    {
        base.Awake();
    }

    public void SetData()
    {
        BattlePlayerData.SetParameter(_level, _hp, _mp, _gold, _exp, _skills.ToArray());
    }

    protected override void Init()
    {
        _level = BattlePlayerData.Level;
        _hp = BattlePlayerData.HP;
        _mp = BattlePlayerData.MP;
        _exp = BattlePlayerData.Exp;
        _isPlayer = true;
        _skills = new List<SkillData>(BattlePlayerData.Skills.Length);
        for (int i = 0; i < BattlePlayerData.Skills.Length; i++)
        {
            _skills[i] = BattlePlayerData.Skills[i];
        }
    }

    public override void ReciveDamage(int damage)
    {
        _hp -= Calculator.DamageCalculation(damage, _defense);
    }

    public override void SelectAction()
    {

    }

    protected override void PlayAction()
    {

    }
}
