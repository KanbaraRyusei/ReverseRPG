using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class BattlePlayerData
{
    public static int Level => _level;
    public static int HP => _hp;
    public static int MP => _mp;
    public static int Gold => _gold;
    public static int Exp => _exp;
    public static SkillData[] Skills => _skills;
    public static ItemData[] Items => _items;

    private static int _level;
    private static int _hp;
    private static int _mp;
    private static int _gold;
    private static int _exp;
    private static SkillData[] _skills;
    private static ItemData[] _items;

    public static void SetParameter(int level, int hp, int mp, int gold, int exp, SkillData[] skills, ItemData[] items)
    {
        _level = level;
        _hp = hp;
        _mp = mp;
        _gold = gold;
        _exp = exp;
        _skills = skills;
        _items = items;
    }
}
