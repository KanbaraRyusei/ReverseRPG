using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BattlePlayer : CharacterBase
{
    public PlayerSelectActionPhase SelectActionPhase => _selectActionPhase;
    public IReadOnlyList<ItemData> Items => _items;

    private Action _action;
    private PlayerSelectActionPhase _selectActionPhase;
    private List<ItemData> _items = new List<ItemData>();

    protected override void Awake()
    {
        base.Awake();
        _selectActionPhase = PlayerSelectActionPhase.None;
    }

    public void SetData()
    {
        BattlePlayerData.SetParameter(_level, _name, _hp, _mp, _attack, _defense, _speed, _gold, _exp, _skills.ToArray(), _items.ToArray());
    }

    public void GetSkill(SkillData skillData)
    {
        _skills.Add(skillData);
    }

    public void GetItem(ItemData itemData)
    {
        _items.Add(itemData);
    }

    public void AddGold(int gold)
    {
        _gold += gold;
    }

    protected override void Init()
    {
        _level = BattlePlayerData.Level;
        _name = BattlePlayerData.Name;
        _hp = BattlePlayerData.HP;
        _mp = BattlePlayerData.MP;
        _attack = BattlePlayerData.Attack;
        _defense = BattlePlayerData.Defence;
        _speed = BattlePlayerData.Speed;
        _exp = BattlePlayerData.Exp;
        _isPlayer = true;
        //_skills = new List<SkillData>(BattlePlayerData.Skills.Length);
        //for (int i = 0; i < BattlePlayerData.Skills.Length; i++)
        //{
        //    _skills[i] = BattlePlayerData.Skills[i];
        //}
    }

    public override void ReciveDamage(int damage)
    {
        var d = Calculator.DamageCalculation(damage, _defense);
        _hp -= d;
        Debug.Log(_name + "��" + d + "�_���[�W���󂯂�");
    }

    public override void SelectAction()
    {
        _selectActionPhase = PlayerSelectActionPhase.SelectAction;
    }

    public override void PlayAction()
    {
        _action?.Invoke();
    }

    public void SetActionPhase(PlayerSelectActionPhase playerSelectActionPhase)
    {
        _selectActionPhase = playerSelectActionPhase;
    }

    public void SetAction(Action action)
    {
        _action = action;
    }

}
public enum PlayerSelectActionPhase
{
    SelectAction,
    SelectEnemy,
    SelectNomalAttack,
    SelectSkill,
    SelectItem,
    SelectMagic,
    RunAway,
    None
}
