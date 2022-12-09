using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class BattleManager : SingletonMonoBehaviour<BattleManager>
{
    public BattlePlayer Player => _player;
    public IReadOnlyList<BattleEnemy> Enemies => _enemys;
    public IReadOnlyList<CharacterBase> Characters => _characters;
    public PhaseManager PhaseManagerInstance => _phaseManager;

    private BattlePlayer _player;

    private List<BattleEnemy> _enemys = new List<BattleEnemy>();

    private CharacterBase[] _characters;

    private PhaseManager _phaseManager;

    protected override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        _phaseManager = new PhaseManager();
        _phaseManager.PlayPhase();
    }

    private void OnDisable()
    {
        _player = null;
        _enemys.Clear();
        _characters = null;
    }

    public void Register(CharacterBase characterBase, bool isPlayer)
    {
        if (isPlayer)
        {
            _player = characterBase as  BattlePlayer;
        }
        else
        {
            _enemys.Add(characterBase as BattleEnemy);
        }
    }
    
    public void CharacterSpeedSort()
    {
        _characters = new CharacterBase[1 + _enemys.Count];
        for(int i = 0; i < _characters.Length; i++)
        {
            if(i == 0)
            {
                _characters[0] = _player;
            }
            else
            {
                _characters[i] = _enemys[i - 1];
            }
        }
        _characters.OrderByDescending(x => x.Speed);
    }

    public void EndBattle()
    {
        _player.SetData();
        SceneLoder.LoadBeforeScene();
    }
}
