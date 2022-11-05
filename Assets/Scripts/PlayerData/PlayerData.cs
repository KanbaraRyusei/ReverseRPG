using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// プレイヤーのデータを格納するScriptableObject
/// </summary>
[CreateAssetMenu(fileName = "PlayerData", menuName = "ScriptableObjects/PlayerData", order = 0)]
public class PlayerData : ScriptableObject
{
    public int Level => _level;
    public int Attack => _attack;
    public int Defense => _defense;
    public int Speed => _speed;
    public int HP => _hP;
    public int MP => _mP;
    public int ExP => _exP;
    public int Gold => _gold;
    public SkillData[] Skill => _skill;

    [SerializeField]
    [Header("レベル")]
    int _level;

    [SerializeField]
    [Header("攻撃力")]
    int _attack;

    [SerializeField]
    [Header("防御力")]
    int _defense;

    [SerializeField]
    [Header("速さ")]
    int _speed;

    [SerializeField]
    [Header("HP")]
    int _hP;

    [SerializeField]
    [Header("MP")]
    int _mP;

    [SerializeField]
    [Header("経験値")]
    int _exP;

    [SerializeField]
    [Header("金")]
    int _gold;

    [SerializeField]
    [Header("スキル")]
    SkillData[] _skill;
}

[Serializable]
public class SkillData
{
    string SkillName => _skillName;
    int Damege => _damege;

    [SerializeField]
    [Header("スキルの名前")]
    string _skillName;

    [SerializeField]
    [Header("ダメージ量")]
    int _damege;
}
