using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Skill�̃f�[�^��ݒ肷��ScriptableObject
/// </summary>
[CreateAssetMenu(fileName ="Skill", menuName ="Skill")]
public abstract class SkillData : ScriptableObject
{
    public string Name => _name;
    public int Damage => _damage;
    public string EffectName => _effectName;

    [SerializeField]
    [Header("���O")]
    private string _name;

    [SerializeField]
    [Header("�_���[�W��")]
    private int _damage;

    [SerializeField]
    [Header("���ʖ�")]
    private string _effectName;

    public abstract void Effect();
}
