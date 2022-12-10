using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterBase : MonoBehaviour, IDamage
{
    public string Name => _name;
    public int Level => _level;
    public int Attack => _attack;
    public int Defense => _defense;
    public int Speed => _speed;
    public int MaxHP => _maxHp;
    public int MaxMP => _maxMp;
    public int HP => _hp;
    public int MP => _mp;
    public int ExP => _exp;
    public int Gold => _gold;
    public bool IsPlayer => _isPlayer;
    public CharacterBase Target => _target;
    public IReadOnlyList<SkillData> Skills => _skills;
    public IReadOnlyList<MagicData> Magics => _magics;

    protected string _name;
    protected int _level;
    protected int _attack;
    protected int _defense;
    protected int _speed;
    protected int _maxHp;
    protected int _maxMp;
    protected int _hp;
    protected int _mp;
    protected int _exp;
    protected int _gold;
    protected bool _isPlayer;
    protected CharacterBase _target;
    protected List<SkillData> _skills;
    protected List<MagicData> _magics;

    protected virtual void Awake()
    {
        Init();
        BattleManager.Instance.Register(this, _isPlayer);
    }

    /// <summary>
    /// ƒf[ƒ^‚ğ‰Šú‰»‚·‚éŠÖ”
    /// </summary>
    protected abstract void Init();
    public abstract void ReciveDamage(int damage);
    public abstract void SelectAction();
    public abstract void PlayAction();

    public virtual void SetTarget(CharacterBase character)
    {
        _target = character;
    }
}
