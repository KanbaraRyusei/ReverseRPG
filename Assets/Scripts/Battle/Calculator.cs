using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Calculator
{
    /// <summary>
    /// �_���[�W�v�Z�̊֐�
    /// �_���[�W = �U���� �� 2 - �h��� �� 4
    /// �[���͐؂�̂�
    /// </summary>
    /// <param name="damage"></param>
    /// <param name="defensePower"></param>
    /// <returns></returns>
    public static int DamageCalculation(int damage, int defensePower)
    {
        float attack = damage / 2;
        float defense = defensePower / 4;
        int attackResult = (int)Mathf.Floor(attack);
        int defenseResult = (int)Mathf.Floor(defense);
        return attackResult - defenseResult;
    }
}
