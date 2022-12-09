using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhaseManager
{
    public BattlePhaseState PhaseState => _battlePhaseState;

    private BattlePhaseState _battlePhaseState;

    private int _index = 0;

    public PhaseManager()
    {
        Debug.Log("BattleStart");
        _index = 0;
        _battlePhaseState = BattlePhaseState.SpeedCheck;
    }

    public void PlayPhase()
    {
        switch(_battlePhaseState)
        {
            case BattlePhaseState.SpeedCheck:
                SpeedCheckPhase();
                break;
            case BattlePhaseState.AliveCheck:
                AliveCheckPhase();
                break;
            default:

                break;
        }
    }

    private void NextPhase()
    {
        switch(_battlePhaseState)
        {
            case BattlePhaseState.SpeedCheck:
                _battlePhaseState = BattlePhaseState.AliveCheck;
                break;
            case BattlePhaseState.AliveCheck:
                _battlePhaseState = BattlePhaseState.SpeedCheck;
                break;
        }
    }

    private void SpeedCheckPhase()
    {
        if(_index > BattleManager.Instance.Characters.Count)
        {
            NextPhase();
            _index = 0;
            return;
        }
        BattleManager.Instance.Characters[_index].SelectAction();
        BattleManager.Instance.Characters[_index].PlayAction();
    }

    private void AliveCheckPhase()
    {
        for(int i = 0; i < BattleManager.Instance.Enemies.Count; i++)
        {
            if(BattleManager.Instance.Enemies[i].HP > 0)
            {
                return;
            }
        }
        if(BattleManager.Instance.Player.HP <= 0)
        {
            BattleManager.Instance.EndBattle();
        }
        BattleManager.Instance.EndBattle();
    }
}
