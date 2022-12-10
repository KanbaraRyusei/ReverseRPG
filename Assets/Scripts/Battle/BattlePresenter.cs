using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UniRx;

public class BattlePresenter : MonoBehaviour
{
    [SerializeField]
    private BattleView _battleView;

    [SerializeField]
    [Header("最初の行動")]
    private string[] _firstActions;

    [SerializeField]
    private BattlePlayer _battlePlayer;

    private void Start()
    {
        _battlePlayer.ObserveEveryValueChanged(x => x.HP)
            .Subscribe(x => _battleView.SetMaxHP(x));

        BattleManager.Instance.PhaseManagerInstance.ObserveEveryValueChanged(x => x.PhaseState)
            .Subscribe(x =>
            {
                if(x == BattlePhaseState.PlayerTurn)
                {
                    _battlePlayer.SelectAction();
                }
            });

        _battlePlayer.ObserveEveryValueChanged(x => x.SelectActionPhase)
            .Subscribe(x =>
            {
                switch (x)
                {
                    case PlayerSelectActionPhase.SelectAction:

                        _battleView.SetButton(_firstActions.Length);
                        _battleView.ButtonTextChenge(_firstActions);
                        Action[] actions = new Action[_firstActions.Length];
                        actions[0] = () => _battlePlayer.SetActionPhase(PlayerSelectActionPhase.SelectEnemy);
                        actions[1] = () => _battlePlayer.SetActionPhase(PlayerSelectActionPhase.None);
                        actions[2] = () => _battlePlayer.SetActionPhase(PlayerSelectActionPhase.SelectSkill);
                        actions[3] = () => _battlePlayer.SetActionPhase(PlayerSelectActionPhase.SelectMagic);
                        actions[4] = () => _battlePlayer.SetActionPhase(PlayerSelectActionPhase.RunAway);
                        
                        _battleView.ButtonActionChange(actions);
                        break;

                    case PlayerSelectActionPhase.SelectEnemy:

                        _battleView.SetButton(BattleManager.Instance.Enemies.Count);

                        string[] enemyNames = new string[BattleManager.Instance.Enemies.Count];
                        for(int i = 0; i < BattleManager.Instance.Enemies.Count; i++)
                        {
                            enemyNames[i] = BattleManager.Instance.Enemies[i].Name;
                        }

                        _battleView.ButtonTextChenge(enemyNames);
                        Action[] selectActions = new Action[BattleManager.Instance.Enemies.Count];
                        selectActions[0] = () =>
                        {
                            _battlePlayer.SetTarget(BattleManager.Instance.Enemies[0]);
                            _battlePlayer.SetActionPhase(PlayerSelectActionPhase.SelectNomalAttack);
                        };
                        _battleView.ButtonActionChange(selectActions);

                        break;

                    case PlayerSelectActionPhase.SelectItem:

                        _battleView.SetButton(_battlePlayer.Items.Count);
                        string[] items = new string[_battlePlayer.Items.Count];
                        for(int i = 0; i < _battlePlayer.Items.Count; i++)
                        {
                            items[i] = _battlePlayer.Items[i].Name;
                        }
                        _battleView.ButtonTextChenge(items);
                        Action[] selectItems = new Action[_battlePlayer.Items.Count];
                        Debug.Log("アイテムは未実装です");
                        break;

                    case PlayerSelectActionPhase.SelectNomalAttack:

                        _battleView.SetButton(1);// ただの攻撃なのでとくに選ぶものがない
                        string[] s = new string[1];
                        s[0] = "Attack";
                        _battleView.ButtonTextChenge(s);
                        Action[] nomalAttack = new Action[1];
                        nomalAttack[0] = () =>
                        {
                            _battlePlayer.Target.GetComponent<BattleEnemy>().ReciveDamage(_battlePlayer.Attack);
                            _battlePlayer.SetActionPhase(PlayerSelectActionPhase.SelectAction);
                        };
                        _battleView.ButtonActionChange(nomalAttack);

                        break;

                    case PlayerSelectActionPhase.SelectSkill:
                        Debug.Log("スキルは未実装です");
                        return;
                        _battleView.SetButton(_battlePlayer.Skills.Count);
                        string[] skills = new string[_battlePlayer.Skills.Count];
                        for(int i = 0; i < _battlePlayer.Skills.Count; i++)
                        {
                            skills[i] = _battlePlayer.Skills[i].Name;
                        }
                        _battleView.ButtonTextChenge(skills);

                        break;

                    case PlayerSelectActionPhase.SelectMagic:
                        Debug.Log("魔法は未実装です");
                        return;
                        _battleView.SetButton(_battlePlayer.Magics.Count);
                        string[] magics = new string[_battlePlayer.Magics.Count];
                        for(int i = 0; i < _battlePlayer.Magics.Count; i++)
                        {
                            magics[i] = _battlePlayer.Magics[i].Name;
                        }
                        _battleView.ButtonTextChenge(magics);

                        break;
                }
            });
    }
}
