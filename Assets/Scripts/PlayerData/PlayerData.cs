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
    public int MaxHP => _maxHP;
    public int MaxMP => _maxMP;
    public int NeedExP => _needExP;
    public SkillData[] Skills => _skills;

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
    int _maxHP;

    [SerializeField]
    [Header("MP")]
    int _maxMP;

    [SerializeField]
    [Header("経験値")]
    int _needExP;

    [SerializeField]
    [Header("スキル")]
    SkillData[] _skills;
}
