using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class BattlePresenter : MonoBehaviour
{
    [SerializeField]
    private BattleView _battleView;

    private BattlePlayer _battlePlayer;

    private void Start()
    {
        _battlePlayer.ObserveEveryValueChanged(x => x.HP)
            .Subscribe(x => _battleView.SetMaxHP(x));
    }
}
