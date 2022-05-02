using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyBase : MonoBehaviour, IDamageable, IHeelable
{
    /// <summary>EnemyのHP</summary>
    public int EnemyHP => _hp;
    /// <summary>Enemyの攻撃力</summary>
    public int EnemyPower => _power;
    /// <summary>Enemyの防御力</summary>
    public int EnemyDefensePower => _defensePower;
    /// <summary>Enemyの素早さ</summary>
    public int EnemySpeed => _speed;

    [SerializeField]
    [Header("EnemyのHP")]
    int _hp;

    [SerializeField]
    [Header("Enemyの攻撃力")]
    int _power;

    [SerializeField]
    [Header("Enemyの防御力")]
    int _defensePower;

    [SerializeField]
    [Header("Enemyの素早さ")]
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
