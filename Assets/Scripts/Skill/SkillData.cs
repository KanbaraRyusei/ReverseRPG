using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Skillのデータを設定するScriptableObject
/// </summary>
[CreateAssetMenu(fileName ="Skill", menuName ="Skill")]
public abstract class SkillData : ScriptableObject
{
    public string Name => _name;
    public int Damage => _damage;
    public string EffectName => _effectName;

    [SerializeField]
    [Header("名前")]
    private string _name;

    [SerializeField]
    [Header("ダメージ量")]
    private int _damage;

    [SerializeField]
    [Header("効果名")]
    private string _effectName;

    public abstract void Effect();
}
