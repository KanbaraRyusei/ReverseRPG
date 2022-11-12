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
        }
        BattleManager.Instance.Characters[_index].SelectAction();
    }

    private void AliveCheckPhase()
    {
        if(BattleManager.Instance.Player.HP <= 0)
        {
            BattleManager.Instance.EndBattle();
        }
    }
}
