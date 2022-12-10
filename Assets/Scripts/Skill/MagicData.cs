using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cysharp.Threading.Tasks;

[CreateAssetMenu(menuName = "Magic", fileName ="Magic")]
public class MagicData : ScriptableObject
{
    public string Name => _name;
    public int Damage => _damage;
    public string EffectName => _effectName;

    [SerializeField]
    [Header("名前")]
    private string _name;

    [SerializeField]
    [Header("ダメージ量")]
    private int _damage;

    [SerializeField]
    [Header("効果名")]
    private string _effectName;

    [SerializeField]
    [Header("エフェクト")]
    private ParticleSystem _effect;

    [SerializeField]
    [Header("エフェクトの再生時間(ミリ秒)")]
    private int _effectTime;

    public async virtual void Effect()
    {
        _effect.gameObject.SetActive(true);
        await UniTask.Delay(_effectTime);
        _effect.gameObject.SetActive(false);
    }
}
