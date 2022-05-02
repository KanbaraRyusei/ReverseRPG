using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerBase : MonoBehaviour, IDamageable, IHeelable
{
    /// <summary>PlayerのHP</summary>
    public int HP => _hp;
    /// <summary>Playerの攻撃力</summary>
    public int Power => _power;
    /// <summary>Playerの防御力</summary>
    public int DefensePower => _defensePower;
    /// <summary>Playerの素早さ</summary>
    public int Speed => _speed;

    [SerializeField]
    [Header("PlayerのHP")]
    int _hp;

    [SerializeField]
    [Header("Playerの攻撃力")]
    int _power;

    [SerializeField]
    [Header("Playerの防御力")]
    int _defensePower;

    [SerializeField]
    [Header("Playerの素早さ")]
    int _speed;


    protected abstract void Attack();

    public void AddDamage(int damage)
    {
        _hp -= damage;
    }

    public void Heel(int heel)
    {
        _hp += heel;
    }
}
