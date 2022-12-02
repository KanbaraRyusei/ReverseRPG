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

    private static int _level;
    private static int _hp;
    private static int _mp;
    private static int _gold;
    private static int _exp;
    private static SkillData[] _skills;

    public static void SetParameter(int level, int hp, int mp, int gold, int exp, SkillData[] skillDatas)
    {
        _level = level;
        _hp = hp;
        _mp = mp;
        _gold = gold;
        _exp = exp;
        _skills = skillDatas;
    }
}
