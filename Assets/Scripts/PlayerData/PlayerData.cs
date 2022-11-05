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
    [Header("スキル")]
    Skill[] _skill;
}

[Serializable]
public class Skill
{
    [SerializeField]
    [Header("スキルの名前")]
    string _skillName;

    [SerializeField]
    [Header("ダメージ量")]
    int _damege;
}
