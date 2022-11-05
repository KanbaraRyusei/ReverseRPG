using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �v���C���[�̃f�[�^���i�[����ScriptableObject
/// </summary>
[CreateAssetMenu(fileName = "PlayerData", menuName = "ScriptableObjects/PlayerData", order = 0)]
public class PlayerData : ScriptableObject
{
    [SerializeField]
    [Header("���x��")]
    int _level;

    [SerializeField]
    [Header("�U����")]
    int _attack;

    [SerializeField]
    [Header("�h���")]
    int _defense;

    [SerializeField]
    [Header("����")]
    int _speed;

    [SerializeField]
    [Header("HP")]
    int _hP;

    [SerializeField]
    [Header("MP")]
    int _mP;

    [SerializeField]
    [Header("�o���l")]
    int _exP;

    [SerializeField]
    [Header("�X�L��")]
    Skill[] _skill;
}

[Serializable]
public class Skill
{
    [SerializeField]
    [Header("�X�L���̖��O")]
    string _skillName;

    [SerializeField]
    [Header("�_���[�W��")]
    int _damege;
}
