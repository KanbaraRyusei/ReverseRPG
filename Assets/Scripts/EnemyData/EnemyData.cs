using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Enemy�̃f�[�^���i�[����ScriptableObject
/// </summary>
[CreateAssetMenu(fileName ="EnemyData", menuName ="EnemyData")]
public class EnemyData : ScriptableObject
{
    public int Level => _level;
    public string Name => _name;
    public int Attack => _attack;
    public int Defense => _defense;
    public int Speed => _speed;
    public int HP => _hP;
    public int MP => _mP;
    public int ExP => _exP;
    public int Gold => _gold;
    public SkillData[] Skills => _skills;

    [SerializeField]
    [Header("���x��")]
    int _level;

    [SerializeField]
    [Header("���O")]
    string _name;

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
    [Header("��")]
    int _gold;

    [SerializeField]
    [Header("�X�L��")]
    SkillData[] _skills;
}
