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
    [Header("���O")]
    private string _name;

    [SerializeField]
    [Header("�_���[�W��")]
    private int _damage;

    [SerializeField]
    [Header("���ʖ�")]
    private string _effectName;

    [SerializeField]
    [Header("�G�t�F�N�g")]
    private ParticleSystem _effect;

    [SerializeField]
    [Header("�G�t�F�N�g�̍Đ�����(�~���b)")]
    private int _effectTime;

    public async virtual void Effect()
    {
        _effect.gameObject.SetActive(true);
        await UniTask.Delay(_effectTime);
        _effect.gameObject.SetActive(false);
    }
}
