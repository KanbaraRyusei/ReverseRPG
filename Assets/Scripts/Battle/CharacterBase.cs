using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterBase : MonoBehaviour, IDamage
{
    public int Level => _level;
    public int Attack => _attack;
    public int Defense => _defense;
    public int Speed => _speed;
    public int HP => _hp;
    public int MP => _mp;
    public int ExP => _exP;
    public int Gold => _gold;
    public bool IsPlayer => _isPlayer;
    public IReadOnlyList<SkillData> Skills => _skills;

    protected int _level;
    protected int _attack;
    protected int _defense;
    protected int _speed;
    protected int _hp;
    protected int _mp;
    protected int _exP;
    protected int _gold;
    protected bool _isPlayer;
    protected List<SkillData> _skills;

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
    protected abstract void PlayAction();
}
