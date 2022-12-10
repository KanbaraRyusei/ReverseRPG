using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattlePlayerDataSetter : MonoBehaviour
{
    [SerializeField]
    private PlayerData _data;

    private void Awake()
    {
        BattlePlayerData.SetParameter(_data.Level, _data.Name, _data.MaxHP, _data.MaxMP, _data.Attack, _data.Defense, _data.Speed, _data.Gold, _data.NeedExP, _data.Skills, null);
    }
}
