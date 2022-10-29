using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterBase : MonoBehaviour, IDamage
{
    public int Level => _level;
    public int Power => _power;
    public int DefensePower => _defensePower;
    public int Speed => _speed;
    public int HP => _hp;
    public int MP => _mp;
    public bool IsPlayer => _isPlayer;
    //public IReadOnlyList<Skill> Skills => _skills;

    protected int _level;
    protected int _power;
    protected int _defensePower;
    protected int _speed;
    protected int _hp;
    protected int _mp;
    protected bool _isPlayer;
    //private List<Skill> _skills;

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
}
