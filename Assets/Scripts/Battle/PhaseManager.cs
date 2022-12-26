using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhaseManager
{
    public BattlePhaseState PhaseState => _battlePhaseState;

    private BattlePhaseState _battlePhaseState;

    public PhaseManager()
    {
        _battlePhaseState = BattlePhaseState.SpeedCheck;
    }

    public void PlayPhase()
    {
        switch (_battlePhaseState)
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
        switch (_battlePhaseState)
        {
            case BattlePhaseState.SpeedCheck:
                _battlePhaseState = BattlePhaseState.AliveCheck;
                break;
            case BattlePhaseState.AliveCheck:
                _battlePhaseState = BattlePhaseState.SpeedCheck;
                break;
        }
        Debug.Log("NextPhase");
    }

    private void SpeedCheckPhase()
    {
        BattleManager.Instance.CharacterSpeedSort();
        for (int i = 0; i < BattleManager.Instance.Characters.Count; i++)
        {
            BattleManager.Instance.Characters[i].SelectAction();
            if (!BattleManager.Instance.Characters[i].IsPlayer)
            {
                BattleManager.Instance.Characters[i].PlayAction();
            }
            Debug.Log(i + "���");
        }
        NextPhase();
    }

    private void AliveCheckPhase()
    {
        Debug.Log("AliveCheck");
        for (int i = 0; i < BattleManager.Instance.Enemies.Count; i++)
        {
            if (BattleManager.Instance.Enemies[i].HP > 0)
            {
                return;
            }
        }
        if (BattleManager.Instance.Player.HP >= 0)
        {
            NextPhase();
        }
        BattleManager.Instance.EndBattle();
    }
}
